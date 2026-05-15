using FinalTallerProg2.Logica.Estudiante;
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

namespace FinalTallerProg2.Vistas.Estudiantes
{
    public partial class CrearEstudiante : Form
    {
        public CrearEstudiante()
        {
            InitializeComponent();
            LipiarCampos();
        }

        public void LipiarCampos()
        {
            txt_nomEst.Text = "";
            txt_dirEst.Text = "";
            txt_carrEst.Text = "";
            txt_dniEst.Text = "";
            txt_edadEst.Text = "0";
        }

        private void CrearEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void btn_crear_estudiantes_Click(object sender, EventArgs e)
        {
            bool estado = false;
            Estudiante est = new Estudiante();

            est.Nombre = txt_nomEst.Text;
            est.Direccion = txt_dirEst.Text;
            est.Carrera = txt_carrEst.Text;
            est.Dni = txt_dniEst.Text;

            if(txt_edadEst.Text == "")
            {
                est.Edad = 0;
            }
            else
            {
                est.Edad = int.Parse(txt_edadEst.Text);

            }


            if (Logica.Estudiante.Estudiante.CrearEstudiante(est))
            {
                MessageBox.Show("Se Creo El estudiante" + est.Nombre + " Exitosamente!",
                "Crear Estudiante",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                estado = Application.OpenForms.OfType<CrearPrestamo>().Any();
                if (!estado)
                {
                    Estudiantes estudiantes = new Estudiantes();
                    estudiantes.Visible = true;

                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrio un Error al crear el estudiante!", 
                 "Crear Estudiante",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }

        private void txt_nomEst_TextChanged(object sender, EventArgs e)
        {
            if (txt_nomEst.Text == "" && string.IsNullOrEmpty(txt_nomEst.Text))
            {
                ep_nomEst.SetError(txt_nomEst, "El nombre es obligatorio!");
            }
            else
            {
                ep_nomEst.SetError(txt_nomEst, "");
            }
        }

        private void txt_dirEst_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_dniEst_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_dniEst.Text, out int result) && txt_dniEst.Text != "")
            {
                ep_dniEst.SetError(txt_dniEst, "El DNI es obligatorio!");
            }
            else if(txt_dniEst.Text.Length > 9)
            {
                ep_dniEst.SetError(txt_dniEst, "Ingrese un DNI valido!");
            }
            else
            {
                ep_dniEst.SetError(txt_dniEst, "");
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            bool estado = false;
            estado = Application.OpenForms.OfType<CrearPrestamo>().Any();

            if (!estado)
            {
                Estudiantes estudiantes = new Estudiantes();
                estudiantes.Visible = true;

            }

            this.Close();
        }

        private void txt_edadEst_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_edadEst.Text, out int result))
            {
                ep_edadEst.SetError(txt_edadEst, "Ingrese una edad valida!");
            }
            else
            {
                ep_edadEst.SetError(txt_edadEst, "");
            }
        }
    }
}
