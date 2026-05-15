using FinalTallerProg2.Logica.Autor;
using FinalTallerProg2.Logica.Libro;
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
        List<Autor> listAutors = new List<Autor>();

        int idAutor = 0;
        int indexAutor = -1;


        public CrearLibro()
        {
            InitializeComponent();
            
        }

        private void LimpiarCampos()
        {
            txt_titulo.Text = "";
            ep_titulo.SetError(txt_titulo, "El titulo es obligatorio!");
            txt_editorial.Text = "";
            txt_area.Text = "";
            cb_autor.SelectedIndex = -1;
            ep_autor.SetError(cb_autor, "Selecciona un autor!");
        }

        private void CrearLibro_Load(object sender, EventArgs e)
        {

            CargarCBAutores();

            LimpiarCampos();
        }

        private void CargarCBAutores()
        {
            listAutors = Autor.ListarAutores();
            foreach (Autor autor in listAutors)
            {
                cb_autor.Items.Add(autor.Nombre);
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Libros libros = new Libros();
            libros.Visible = true;
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

        private void cb_autor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(cb_autor.SelectedIndex == -1)
            {
                ep_autor.SetError(cb_autor, "Selecciona un autor!");
            }
            else
            {
                ep_autor.SetError(cb_autor, "");
                indexAutor = cb_autor.SelectedIndex;

                idAutor = listAutors[indexAutor].IdAutor;

            }
        }

        private void btn_crear_libro_Click(object sender, EventArgs e)
        {
            Libro libro = new Libro();
            bool estado = false;

            libro.Titulo = txt_titulo.Text;
            libro.Area = txt_area.Text;
            libro.Editorial = txt_editorial.Text;
            libro.Autor = idAutor.ToString();

            estado = Libro.CrearLibro(libro);

            if(estado)
            {
                MessageBox.Show("Se Creo el libro "+libro.Titulo+" exitosamente!","Crear Libro",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo crear el libro!", "Crear Libro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
