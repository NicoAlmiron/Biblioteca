using Entidades;
using Negocio;
using FinalTallerProg2.Vistas.Estudiantes;
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
    public partial class EstudiantesInfo : Form
    {
        public EstudiantesInfo()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            // los datos los traigo de la capa de negocio
            ResumenEstudiantes resumen = ResumenNegocio.ObtenerResumenEstudiantes();

            label1.Text = "- Cantidad de Estudiantes Totales: " + resumen.EstudiantesTotales;
            label2.Text = "- Carrera con mayor cantidad de estudiantes: " + resumen.CarreraMayorEstudiantes;
            label5.Text = "- Carrera con menor cantidad de estudiantes: " + resumen.CarreraMenorEstudiantes;
            label6.Text = "- Estudiantes con mayor edad: " + resumen.EstudianteMayorEdad;
            label7.Text = "- Estudiantes con menor edad: " + resumen.EstudianteMenorEdad;
        }

        private void btn_estudiantes_Click(object sender, EventArgs e)
        {
            Estudiantes.Estudiantes estudiantes = new Estudiantes.Estudiantes();

            // escondo la ventana de inicio mientras esta abierta la de estudiantes
            Form inicio = (Form)this.TopLevelControl;
            inicio.Hide();
            estudiantes.ShowDialog();
            // al volver la muestro de nuevo y recargo los datos
            inicio.Show();
            CargarDatos();
        }
    }
}
