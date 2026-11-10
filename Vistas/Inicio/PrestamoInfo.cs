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

namespace FinalTallerProg2.Vistas.Inicio
{
    public partial class PrestamoInfo : Form
    {
        public PrestamoInfo()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            // ahora le pido los datos a la capa de negocio en vez de hacer las consultas aca
            ResumenPrestamos resumen = ResumenNegocio.ObtenerResumenPrestamos();

            label1.Text = "- Cantidad de prestamos activos: " + resumen.PrestamosActivos;
            label2.Text = "- Cantidad de prestamos fuera de tiempo: " + resumen.PrestamosVencidos;
            label5.Text = "- Cantidad de prestamos totales: " + resumen.PrestamosTotales;
            label6.Text = "- Libro mas prestado: " + resumen.LibroMasPrestado;
            label8.Text = "- Cantidad de veces prestado: " + resumen.VecesLibroMasPrestado;
            label7.Text = "- Libro menos prestado: " + resumen.LibroMenosPrestado;
            label9.Text = "- Alumno con mas prestamos: " + resumen.AlumnoMasPrestamos;
            label10.Text = "- Cantidad de prestamos: " + resumen.CantPrestamosAlumno;
        }

        private void btn_estudiantes_Click(object sender, EventArgs e)
        {
            PrestamosV prestamos = new PrestamosV();

            // escondo la ventana de inicio mientras esta abierta la lista de prestamos
            Form inicio = (Form)this.TopLevelControl;
            inicio.Hide();
            prestamos.ShowDialog();
            // al volver la muestro de nuevo y recargo los datos
            inicio.Show();
            CargarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearPrestamo crearPrestamo = new CrearPrestamo();

            // lo mismo que arriba pero con la pantalla de crear prestamo
            Form inicio = (Form)this.TopLevelControl;
            inicio.Hide();
            crearPrestamo.ShowDialog();
            inicio.Show();
            CargarDatos();
        }
    }
}
