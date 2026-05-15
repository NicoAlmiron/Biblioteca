using FinalTallerProg2.Vistas.Autores;
using FinalTallerProg2.Vistas.Estudiantes;
using FinalTallerProg2.Vistas.Inicio;
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

namespace FinalTallerProg2
{
    public partial class Inicio : Form
    {
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
        }

        private void btn_prestamo_Click(object sender, EventArgs e)
        {
            btn_default();

            AbrirForm(new PrestamoInfo());

            this.btn_prestamo.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void btn_alumnos_Click(object sender, EventArgs e)
        {

            AbrirForm(new EstudiantesInfo());

        }

        private void btn_autores_Click(object sender, EventArgs e)
        {
            btn_default();

            AbrirForm(new AutoresInfo());

            this.btn_autores.BackColor = System.Drawing.SystemColors.ActiveCaption;

        }

        private void btn_libros_Click(object sender, EventArgs e)
        {
            btn_default();

            AbrirForm(new LibrosInfo());

            this.btn_libros.BackColor = System.Drawing.SystemColors.ActiveCaption;

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            btn_default();

            AbrirForm(new PrestamoInfo());

            this.btn_prestamo.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void AbrirForm(object formHijo)
        {
            if(this.panel_general.Controls.Count > 0)
            {
                this.panel_general.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_general.Controls.Add(fh);
            fh.Show();

        }

        private void btn_prueba_Click(object sender, EventArgs e)
        {
            AbrirForm(new LibrosInfo());
        }

        private void btn_alumno_Click(object sender, EventArgs e)
        {
            btn_default();

            AbrirForm(new EstudiantesInfo());

            this.btn_alumno.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void panel_general_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
