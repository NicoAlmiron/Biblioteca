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
            CargarLista(LibroNegocio.ListarLibros());            
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

            // escondo esta pantalla, abro la de crear y espero a que se cierre
            this.Hide();
            crearLibro.ShowDialog();
            // cuando vuelve la muestro de nuevo y recargo la grilla
            this.Show();
            CargarDatos();
        }

        private void btn_editar_libro_Click(object sender, EventArgs e)
        {
            if(idLibro > 0)
            {
                EditarLibros editarLibros = new EditarLibros();

                // primero le cargo los datos y despues la muestro
                editarLibros.CargarDatosTxt(ref idLibro);
                this.Hide();
                editarLibros.ShowDialog();
                this.Show();
                CargarDatos();
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
            // si se hace clic en el encabezado RowIndex es -1, ahi no hay libro
            if (e.RowIndex < 0) return;
            idLibro = Convert.ToInt32(dgv_libros.Rows[e.RowIndex].Cells[0].Value);
        }

        // con el clic derecho tambien selecciono el libro, asi el menu (Editar / Eliminar) actua sobre esa fila
        private void dgv_libros_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgv_libros.CurrentCell = dgv_libros.Rows[e.RowIndex].Cells[Math.Max(e.ColumnIndex, 0)];
                idLibro = Convert.ToInt32(dgv_libros.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void txt_buscador_TextChanged(object sender, EventArgs e)
        {
            if(cb_campos.Text != "" && cb_campos.Text != "Autor" )
            {
                string txtBuscar, campo;

                txtBuscar = txt_buscador.Text;

                campo = cb_campos.Text;

                CargarLista(LibroNegocio.Buscador(txtBuscar, campo));

                ep_categoria.SetError(txt_buscador, "");
            }
            else if(cb_campos.Text == "Autor")
            {
                string txtBuscar;

                txtBuscar = txt_buscador.Text;

                // lo de armar los ids de los autores ahora lo hace la capa de negocio
                CargarLista(LibroNegocio.BuscarPorNombreAutor(txtBuscar));
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

            if(idLibro > 0 && LibroNegocio.TienePrestamos(idLibro))
            {
                MessageBox.Show("No se puede eliminar este libro porque tiene prestamos registrados.", "Eliminar Libro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(idLibro > 0)
            {
                respuesta = MessageBox.Show("Estas seguro que quieres eliminar este libro?\nEsta accion no se puede revertir!", "Eliminar Libro"
                    , MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.OK)
                {
                    result = LibroNegocio.EliminarLibro(idLibro);
                    if (result)
                    {
                        MessageBox.Show("Se elimino el libro Exitosamente!", "Eliminar Libro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        idLibro = -1;
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
