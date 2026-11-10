using Entidades;
using Negocio;
using FinalTallerProg2.Vistas.Prestamos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTallerProg2.Vistas.Libros
{
    public partial class CrearLibro : Form
    {
        // misma lista y en el mismo orden que los items del CheckedListBox
        List<Autor> listAutors = new List<Autor>();

        public CrearLibro()
        {
            InitializeComponent();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txt_titulo.Text = "";
            ep_titulo.SetError(txt_titulo, "El titulo es obligatorio!");
            txt_editorial.Text = "";
            txt_area.Text = "";
            for (int i = 0; i < clb_autores.Items.Count; i++)
            {
                clb_autores.SetItemChecked(i, false);
            }
            ep_autor.SetError(clb_autores, "Selecciona al menos un autor!");
        }

        private void CrearLibro_Load(object sender, EventArgs e)
        {

            CargarAutores();

            LimpiarCampos();
        }

        private void CargarAutores()
        {
            clb_autores.Items.Clear();
            listAutors = AutorNegocio.ListarAutores();
            foreach (Autor autor in listAutors)
            {
                clb_autores.Items.Add(autor.Nombre);
            }
        }

        // ids de los autores tildados (el indice del item es el mismo que en listAutors)
        private List<int> AutoresTildados()
        {
            List<int> ids = new List<int>();
            foreach (int indice in clb_autores.CheckedIndices)
            {
                ids.Add(listAutors[indice].IdAutor);
            }
            return ids;
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            // solo cierro, la pantalla que me abrio (Libros o Crear Prestamo) se vuelve a mostrar sola
            this.Close();
        }

        private void txt_titulo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_titulo.Text))
            {
                ep_titulo.SetError(txt_titulo, "");
            }
            else
            {
                ep_titulo.SetError(txt_titulo, "El titulo es obligatorio!");
            }
        }

        // ItemCheck se dispara ANTES de que cambie el tilde, por eso calculo cuantos van a quedar
        private void clb_autores_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int tildados = clb_autores.CheckedItems.Count + (e.NewValue == CheckState.Checked ? 1 : -1);

            if (tildados > 0)
            {
                ep_autor.SetError(clb_autores, "");
            }
            else
            {
                ep_autor.SetError(clb_autores, "Selecciona al menos un autor!");
            }
        }

        private void btn_crear_libro_Click(object sender, EventArgs e)
        {
            Libro libro = new Libro();
            bool estado = false;

            libro.Titulo = txt_titulo.Text;
            libro.Area = txt_area.Text;
            libro.Editorial = txt_editorial.Text;
            libro.IdAutores = AutoresTildados();

            if (libro.IdAutores.Count == 0)
            {
                MessageBox.Show("Tenes que tildar al menos un autor!", "Crear Libro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            estado = LibroNegocio.CrearLibro(libro);

            if(estado)
            {
                MessageBox.Show("Se Creo el libro "+libro.Titulo+" exitosamente!","Crear Libro",MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("No se pudo crear el libro!", "Crear Libro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarAutor cargarAutor = new CargarAutor();

            // guardo los autores tildados para volver a tildarlos despues de recargar la lista
            List<int> tildados = AutoresTildados();

            // escondo esta pantalla mientras se carga el autor
            this.Hide();
            cargarAutor.ShowDialog();
            this.Show();

            CargarAutores();

            for (int i = 0; i < listAutors.Count; i++)
            {
                if (tildados.Contains(listAutors[i].IdAutor))
                {
                    clb_autores.SetItemChecked(i, true);
                }
            }
        }
    }
}
