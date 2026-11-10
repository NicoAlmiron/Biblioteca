using FinalTallerProg2.Vistas.Autores;
using FinalTallerProg2.Vistas.Consultas;
using FinalTallerProg2.Vistas.Estudiantes;
using FinalTallerProg2.Vistas.Inicio;
using FinalTallerProg2.Vistas.Libros;
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

namespace FinalTallerProg2
{
    public partial class Inicio : Form
    {
        // boton de la seccion que se esta mostrando, para poder recargarla al volver de otra pantalla
        private Button seccionActual;

        public Inicio()
        {
            InitializeComponent();
        }

        private void btn_default()
        {
            this.btn_libros.BackColor = System.Drawing.Color.RoyalBlue;

            this.btn_alumno.BackColor = System.Drawing.Color.RoyalBlue;

            this.btn_autores.BackColor = System.Drawing.Color.RoyalBlue;

            this.btn_prestamo.BackColor = System.Drawing.Color.RoyalBlue;

            this.btn_consultas.BackColor = System.Drawing.Color.RoyalBlue;
        }

        // pinta el boton elegido y abre su pantalla en el panel de la derecha
        private void MostrarSeccion(Button boton, Form pantalla)
        {
            btn_default();

            AbrirForm(pantalla);

            boton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            seccionActual = boton;
        }

        private void btn_prestamo_Click(object sender, EventArgs e)
        {
            MostrarSeccion(btn_prestamo, new PrestamoInfo());
        }

        private void btn_autores_Click(object sender, EventArgs e)
        {
            MostrarSeccion(btn_autores, new AutoresInfo());
        }

        private void btn_libros_Click(object sender, EventArgs e)
        {
            MostrarSeccion(btn_libros, new LibrosInfo());
        }

        private void btn_alumno_Click(object sender, EventArgs e)
        {
            MostrarSeccion(btn_alumno, new EstudiantesInfo());
        }

        private void btn_consultas_Click(object sender, EventArgs e)
        {
            MostrarSeccion(btn_consultas, new ConsultasV());
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            MostrarSeccion(btn_prestamo, new PrestamoInfo());
        }

        private void AbrirForm(object formHijo)
        {
            if(this.panel_general.Controls.Count > 0)
            {
                // cierro la pantalla anterior para liberar sus recursos
                Control anterior = this.panel_general.Controls[0];
                this.panel_general.Controls.RemoveAt(0);
                anterior.Dispose();
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_general.Controls.Add(fh);
            fh.Show();

        }

        private void panel_general_Paint(object sender, PaintEventArgs e)
        {

        }

        // ---------- MenuStrip ----------

        // abre una pantalla de administracion como ventana aparte (igual que los botones de las pantallas Info)
        // y al volver recargo la seccion actual para que se vean los cambios
        private void AbrirVentana(Form ventana)
        {
            this.Hide();
            ventana.ShowDialog();
            this.Show();

            if (seccionActual != null)
            {
                seccionActual.PerformClick();
            }
        }

        private void tsmi_listaPrestamos_Click(object sender, EventArgs e)
        {
            AbrirVentana(new PrestamosV());
        }

        private void tsmi_nuevoPrestamo_Click(object sender, EventArgs e)
        {
            AbrirVentana(new CrearPrestamo());
        }

        private void tsmi_admLibros_Click(object sender, EventArgs e)
        {
            AbrirVentana(new Vistas.Libros.Libros());
        }

        private void tsmi_admAutores_Click(object sender, EventArgs e)
        {
            AbrirVentana(new Vistas.Autores.Autores());
        }

        private void tsmi_admEstudiantes_Click(object sender, EventArgs e)
        {
            AbrirVentana(new Vistas.Estudiantes.Estudiantes());
        }

        private void tsmi_salir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Desea salir de la aplicacion?", "Salir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
