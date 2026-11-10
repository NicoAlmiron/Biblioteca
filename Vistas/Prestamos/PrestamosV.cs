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

namespace FinalTallerProg2
{
    public partial class PrestamosV : Form
    {
        // lo que se ve en la grilla (puede estar filtrado)
        BindingList<Prestamo> listaPrestamos = new BindingList<Prestamo>();
        // todos los prestamos que traje de la bd, sobre esta lista aplico los filtros
        List<Prestamo> todosLosPrestamos = new List<Prestamo>();

        public PrestamosV()
        {
            InitializeComponent();
        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            CargarGrid();
            CargarDatos();
        }

        public void CargarGrid()
        {
            dgv_prestamos.DataSource = listaPrestamos;
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_crear_estudiantes_Click(object sender, EventArgs e)
        {
            Vistas.Prestamos.CrearPrestamo crearPrestamo = new Vistas.Prestamos.CrearPrestamo();

            // escondo la lista mientras se crea el prestamo
            this.Hide();
            crearPrestamo.ShowDialog();
            // al volver la muestro y recargo para que aparezca el prestamo nuevo
            this.Show();
            CargarDatos();
        }

        // trae los prestamos de la bd y aplica los filtros que esten puestos
        public void CargarDatos()
        {
            todosLosPrestamos = PrestamoNegocio.ListarPrestamos();
            AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            // el RadioButton elegido dice en que columna busco
            string campo = rb_estudiante.Checked ? "Estudiante" : "Titulo";

            CargarLista(PrestamoNegocio.Filtrar(todosLosPrestamos, txt_buscador.Text, campo, chk_pendientes.Checked));
        }

        private void CargarLista(List<Prestamo> resultLista)
        {
            listaPrestamos.Clear();

            foreach (Prestamo prestamo in resultLista)
            {
                listaPrestamos.Add(prestamo);
            }
        }

        // el TextBox, los RadioButton y el CheckBox usan este mismo evento
        private void Filtros_Changed(object sender, EventArgs e)
        {
            // cuando cambia un RadioButton se disparan 2 eventos (el que se destilda y el que se tilda),
            // con este if solo filtro una vez
            RadioButton rb = sender as RadioButton;
            if (rb != null && !rb.Checked)
            {
                return;
            }

            AplicarFiltros();
        }

        private Prestamo PrestamoSeleccionado()
        {
            if (dgv_prestamos.CurrentRow == null)
            {
                return null;
            }
            return dgv_prestamos.CurrentRow.DataBoundItem as Prestamo;
        }

        // lo usan el boton Devolver y la opcion del menu contextual (clic derecho)
        private void btn_devolver_Click(object sender, EventArgs e)
        {
            Prestamo prestamo = PrestamoSeleccionado();

            if (prestamo == null)
            {
                MessageBox.Show("No se selecciono ningun prestamo!", "Devolver Libro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (prestamo.Devuelto)
            {
                MessageBox.Show("Este prestamo ya fue devuelto.", "Devolver Libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "Confirmar la devolucion del libro \"" + prestamo.Libro + "\"\nprestado a " + prestamo.Estudiante + "?",
                "Devolver Libro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                if (PrestamoNegocio.Devolver(prestamo.IdPrestamo))
                {
                    MessageBox.Show("Se registro la devolucion!", "Devolver Libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la devolucion!", "Devolver Libro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // con el clic derecho tambien selecciono la fila, asi el menu actua sobre esa fila
        private void dgv_prestamos_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgv_prestamos.CurrentCell = dgv_prestamos.Rows[e.RowIndex].Cells[Math.Max(e.ColumnIndex, 0)];
            }
        }

        // si no hay prestamo seleccionado no muestro el menu; si ya esta devuelto desactivo la opcion
        private void cms_prestamos_Opening(object sender, CancelEventArgs e)
        {
            Prestamo prestamo = PrestamoSeleccionado();

            if (prestamo == null)
            {
                e.Cancel = true;
                return;
            }

            tsmi_devolver.Enabled = !prestamo.Devuelto;
        }
    }
}
