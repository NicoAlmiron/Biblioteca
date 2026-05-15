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
    public partial class EditarLibros : Form
    {
        List<Autor> listAutors = new List<Autor>();

        int indexAutor = -1;
        int idAutor = -1;
        int idLib = -1;

        public EditarLibros()
        {
            InitializeComponent();
        }

        private void EditarLibros_Load(object sender, EventArgs e)
        {
            CargarCBAutores();
        }

        public void CargarDatosTxt(ref int idLibro)
        {
            Libro libro = new Libro();
            idLib = idLibro;
            libro = Libro.ObtenerLibroId(idLibro);

            string autor = "";

            autor = Autor.NombreAutor(Convert.ToInt32(libro.Autor));

            txt_titulo.Text = libro.Titulo;
            txt_editorial.Text = libro.Editorial;
            txt_area.Text = libro.Area;

            cb_autor.SelectedItem = autor;

        }

        private void CargarCBAutores()
        {
            listAutors = Autor.ListarAutores();
            foreach (Autor autor in listAutors)
            {
                cb_autor.Items.Add(autor.Nombre);
            }
        }

        private void btn_editar_libro_Click(object sender, EventArgs e)
        {
            Libro libEditado = new Libro();
            bool result = false;
            if(txt_titulo.Text != "" && idAutor > -1)
            {
                libEditado.IdLibro = idLib;
                libEditado.Titulo = txt_titulo.Text;
                libEditado.Editorial = txt_editorial.Text;
                libEditado.Area = txt_area.Text;
                libEditado.Autor = idAutor.ToString();

                result = Libro.EditarLibro(libEditado);

                if (result)
                {
                    MessageBox.Show("Se Editaron los datos correctamente!", "Editar Libro", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Libros libros = new Libros();
                    libros.Visible = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo editar los datos!", "Editar Libro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            


        }

        private void cb_autor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_autor.SelectedIndex == -1)
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
    }
}
