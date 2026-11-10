using Entidades;
using Negocio;
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
    public partial class EditarLibros : Form
    {
        // misma lista y en el mismo orden que los items del CheckedListBox
        List<Autor> listAutors = new List<Autor>();

        int idLib = -1;

        public EditarLibros()
        {
            InitializeComponent();
        }

        private void EditarLibros_Load(object sender, EventArgs e)
        {
            // muevo la lista para que se vea el primer autor tildado
            // (lo hago aca porque en CargarDatosTxt la ventana todavia no existe y no tiene efecto)
            if (clb_autores.CheckedIndices.Count > 0)
            {
                clb_autores.TopIndex = clb_autores.CheckedIndices[0];
            }
        }

        public void CargarDatosTxt(ref int idLibro)
        {
            // cargo los autores aca y no en el Load, porque este metodo se llama antes de mostrar
            // la pantalla y si la lista esta vacia no puedo tildar los autores del libro
            CargarAutores();

            Libro libro = new Libro();
            idLib = idLibro;
            libro = LibroNegocio.ObtenerLibroId(idLibro);

            txt_titulo.Text = libro.Titulo;
            txt_editorial.Text = libro.Editorial;
            txt_area.Text = libro.Area;

            // tildo los autores que el libro tiene en LibAut
            for (int i = 0; i < listAutors.Count; i++)
            {
                if (libro.IdAutores.Contains(listAutors[i].IdAutor))
                {
                    clb_autores.SetItemChecked(i, true);
                }
            }
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

        private List<int> AutoresTildados()
        {
            List<int> ids = new List<int>();
            foreach (int indice in clb_autores.CheckedIndices)
            {
                ids.Add(listAutors[indice].IdAutor);
            }
            return ids;
        }

        private void btn_editar_libro_Click(object sender, EventArgs e)
        {
            Libro libEditado = new Libro();
            bool result = false;

            List<int> autores = AutoresTildados();

            if (txt_titulo.Text == "" || autores.Count == 0)
            {
                MessageBox.Show("El titulo es obligatorio y tenes que tildar al menos un autor!", "Editar Libro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            libEditado.IdLibro = idLib;
            libEditado.Titulo = txt_titulo.Text;
            libEditado.Editorial = txt_editorial.Text;
            libEditado.Area = txt_area.Text;
            libEditado.IdAutores = autores;

            result = LibroNegocio.EditarLibro(libEditado);

            if (result)
            {
                MessageBox.Show("Se Editaron los datos correctamente!", "Editar Libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // vuelvo a la lista, que se recarga sola con los cambios
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo editar los datos!", "Editar Libro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_volver_Click(object sender, EventArgs e)
        {
            // solo cierro, la lista de libros se vuelve a mostrar sola
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
    }
}
