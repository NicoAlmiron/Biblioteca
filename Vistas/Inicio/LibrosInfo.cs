using Entidades;
using Negocio;
using FinalTallerProg2.Vistas.Libros;
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
    public partial class LibrosInfo : Form
    {
        public LibrosInfo()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            // los datos los traigo de la capa de negocio
            ResumenLibros resumen = ResumenNegocio.ObtenerResumenLibros();

            label2.Text = "- Cantidad de Libros Prestados: " + resumen.LibrosPrestados;
            label3.Text = "- Cantidad de Entidades en la biblioteca: " + resumen.LibrosEnBiblioteca;
            label1.Text = "- Cantidad Categorias Distintas: " + resumen.CategoriasDistintas;
            label5.Text = "- Cantidad Editoriales Distintas: " + resumen.EditorialesDistintas;
        }

        private void btn_libros_Click(object sender, EventArgs e)
        {
            Libros.Libros ventanaLibro = new Libros.Libros();

            // escondo la ventana de inicio mientras esta abierta la de libros
            Form inicio = (Form)this.TopLevelControl;
            inicio.Hide();
            ventanaLibro.ShowDialog();
            // al volver la muestro de nuevo y recargo los datos
            inicio.Show();
            CargarDatos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
