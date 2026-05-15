using FinalTallerProg2.Logica.Estudiante;
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

    public partial class EditarEstudiante : Form
    {
        public int idEstudiante;
        public EditarEstudiante()
        {
            InitializeComponent();
        }

        public void CargarDatos(ref int id)
        {
            Estudiante estudiante = new Estudiante();
            
            estudiante = Logica.Estudiante.Estudiante.BuscarPorIdEstudiante(id);

            idEstudiante = id;

            txt_nomEst.Text = estudiante.Nombre.ToString();
            txt_dirEst.Text = estudiante.Direccion.ToString();
            txt_carrEst.Text = estudiante.Carrera.ToString();
            txt_dniEst.Text = estudiante.Dni.ToString();
            txt_edadEst.Text = estudiante.Edad.ToString();
            
        }


        private void EditarEstudiante_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Estudiantes estudiantes = new Estudiantes();
            estudiantes.Visible = true;

            this.Close();

        }



        private void btn_crear_estudiantes_Click(object sender, EventArgs e)
        {
            Estudiante estudianteEditado = new Estudiante();
            bool resultado = false;

            estudianteEditado.IdEstudiante = idEstudiante;
            estudianteEditado.Nombre = txt_nomEst.Text;
            estudianteEditado.Direccion = txt_dirEst.Text;
            estudianteEditado.Carrera = txt_carrEst.Text;
            estudianteEditado.Dni = txt_dniEst.Text;
            estudianteEditado.Edad = int.Parse(txt_edadEst.Text);

            resultado = Logica.Estudiante.Estudiante.EditarEstudiante(estudianteEditado);

            if (resultado)
            {
                MessageBox.Show("Se editaron los datos correctamente!", "Editar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Estudiantes estudiantes = new Estudiantes();
                estudiantes.Visible = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("ah ocurrido un error inesperado!", "Editar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_edadEst_TextChanged(object sender, EventArgs e)
        {
            if(!int.TryParse(txt_edadEst.Text, out int result))
            {
                ep_edad.SetError(txt_edadEst,"Ingrese una edad valida!");
            }
            else
            {
                ep_edad.SetError(txt_edadEst, "");
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

        private void txt_dniEst_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_dniEst.Text, out int result) && txt_dniEst.Text != "")
            {
                ep_dniEst.SetError(txt_dniEst, "El DNI es obligatorio!");
            }
            else if (txt_dniEst.Text.Length > 9)
            {
                ep_dniEst.SetError(txt_dniEst, "Ingrese un DNI valido!");
            }
            else
            {
                ep_dniEst.SetError(txt_dniEst, "");
            }
        }
    }
}
