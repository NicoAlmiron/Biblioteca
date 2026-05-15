using FinalTallerProg2.Logica;
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
        BindingList<Prestamo> listaPrestamos = new BindingList<Prestamo>();
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

            crearPrestamo.Visible = true;
            this.Close();
        }

        public void CargarDatos()
        {
            CargarLista(Prestamo.ListarPrestamos());
        }

        private void CargarLista(List<Prestamo> resultLista)
        {
            listaPrestamos.Clear();

            foreach(Prestamo prestamo in resultLista)
            {
                listaPrestamos.Add(prestamo);
            }

        }
    }
}
