using Entidades;
using Negocio;
using FinalTallerProg2.Vistas.Autores;
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
    public partial class AutoresInfo : Form
    {
        public AutoresInfo()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            // los datos los traigo de la capa de negocio
            ResumenAutores resumen = ResumenNegocio.ObtenerResumenAutores();

            label1.Text = "Cantidad de Autores Registrados: " + resumen.AutoresRegistrados;
            label2.Text = "Cantidad Maxima de Libros de un autor: " + resumen.MaxLibrosPorAutor;
            label4.Text = "Cantidad Minima de Libros de un autor: " + resumen.MinLibrosPorAutor;
            label5.Text = "Nacionalidad mas en comun: " + resumen.NacionalidadMasComun;
        }

        private void btn_estudiantes_Click(object sender, EventArgs e)
        {
            Autores.Autores autores = new Autores.Autores();

            // esta pantalla esta metida dentro del panel de Inicio, asi que escondo la ventana principal
            Form inicio = (Form)this.TopLevelControl;
            inicio.Hide();
            // ShowDialog espera aca hasta que se cierre la pantalla de autores
            autores.ShowDialog();
            // cuando vuelve muestro de nuevo el inicio y recargo los datos por si cambiaron
            inicio.Show();
            CargarDatos();
        }
    }
}
