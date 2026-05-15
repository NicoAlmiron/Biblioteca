using FinalTallerProg2.Logica.Autor;
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

namespace FinalTallerProg2.Vistas.Libros
{
    public partial class CargarAutor : Form
    {
        bool nom = false;
        bool nac = false;
        public CargarAutor()
        {
            InitializeComponent();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarAutor_Load(object sender, EventArgs e)
        {

            LimpiarCampos();
        }


        public void LimpiarCampos()
        {
            txt_nacionalidad.Text = "";
            ep_nacionalidad.SetError(txt_nacionalidad, "La nacionalidad es obligatoria!");
            txt_nombre.Text = "";
            ep_nombre.SetError(txt_nombre, "El nombre es obligatorio!");
            btn_crear_autor.Enabled = false;
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "" && string.IsNullOrEmpty(txt_nombre.Text))
            {
                ep_nombre.SetError(txt_nombre, "El nombre es obligatorio!");
                nom = false;
            } 
            else
            {
                ep_nombre.SetError(txt_nombre, "");
                nom = true;
            }

            if(nom == true && nac == true)
            {
                btn_crear_autor.Enabled = true;
            }
            else
            {
                btn_crear_autor.Enabled = false;
            }
        }

        private void txt_nacionalidad_TextChanged(object sender, EventArgs e)
        {
            if (txt_nacionalidad.Text == "" && string.IsNullOrEmpty(txt_nacionalidad.Text))
            {
                ep_nacionalidad.SetError(txt_nacionalidad, "La nacionalidad es obligatoria!");
                nac = false;
            }
            else
            {
                ep_nacionalidad.SetError(txt_nacionalidad, "");
                nac = true;
            }
            if (nom == true && nac == true)
            {
                btn_crear_autor.Enabled = true;
            }
            else
            {
                btn_crear_autor.Enabled = false;
            }
        }

        private void btn_crear_autor_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor();


            autor.Nombre = txt_nombre.Text;
            autor.Nacionalidad = txt_nacionalidad.Text;
            
            if(autor.Nombre == "" && autor.Nacionalidad == "")
            {
                MessageBox.Show("Los campos son obligatorios!",
                    "Crear Autor", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                if (Autor.CrearAutor(autor))
                {
                    MessageBox.Show("El autor se creo correctamente!",
                        "Crear Autor", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrio un problema al crear el autor!",
                        "Crear Autor", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }



        }
    }
}
