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
    public partial class Libros : Form
    {

        BindingList<Libro> listaLibros = new BindingList<Libro>();

        private int idLibro = -1;

        public Libros()
        {
            InitializeComponent();
            dgv_libros.DataSource = listaLibros;
        }

        private void Libros_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        public void CargarDatos()
        {
            CargarLista(Libro.ListarLibros());            
        }

        private void CargarLista(List<Libro> resultadoLista)
        {
            listaLibros.Clear();
            foreach (Libro libro in resultadoLista)
            {
                listaLibros.Add(libro);
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_crear_libro_Click(object sender, EventArgs e)
        {
            CrearLibro crearLibro = new CrearLibro();

            crearLibro.Visible = true;
            this.Close();
        }

        private void btn_editar_libro_Click(object sender, EventArgs e)
        {
            if(idLibro > 0)
            {
                EditarLibros editarLibros = new EditarLibros();

                editarLibros.Visible = true;
                editarLibros.CargarDatosTxt(ref idLibro);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se a seleccionado a ningun libro!", "Editar Libro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgv_libros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgv_libros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idLibro = Convert.ToInt32(dgv_libros.Rows[e.RowIndex].Cells[0].Value);
        }

        private void txt_buscador_TextChanged(object sender, EventArgs e)
        {
            if(cb_campos.Text != "" && cb_campos.Text != "Autor" )
            {
                string txtBuscar, campo;

                txtBuscar = txt_buscador.Text;

                campo = cb_campos.Text;

                CargarLista(Libro.Buscador(txtBuscar, campo));

                ep_categoria.SetError(txt_buscador, "");
            }
            else if(cb_campos.Text == "Autor")
            {
                string txtBuscar;
                string idAutores = "";

                txtBuscar = txt_buscador.Text;

                List<Autor> autors = new List<Autor>();

                autors = Autor.Buscador(txtBuscar, "Nombre");

                foreach(Autor autor in autors)
                {
                    if(idAutores.Count() > 0)
                    {
                        idAutores += ", " + autor.IdAutor; 
                    }
                    else
                    {
                        idAutores += autor.IdAutor;
                    }
                }

                CargarLista(Libro.BuscarPorAutor(idAutores));
            }
            else
            {
                ep_categoria.SetError(txt_buscador, "Ingrese una categoria!");
            }
        }

        private void cb_campos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_libro_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            bool result = false;

            if(idLibro > 0)
            {
                respuesta = MessageBox.Show("Estas seguro que quieres eliminar este libro?\nEsta accion no se puede revertir!", "Eliminar Libro"
                    , MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.OK)
                {
                    result = Libro.EliminarLibro(idLibro);
                    if (result)
                    {
                        MessageBox.Show("Se elimino el libro Exitosamente!", "Eliminar Libro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Eliminar el libro!", "Eliminar Libro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se selecciono ningun Libro!", "Eliminar Libro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
