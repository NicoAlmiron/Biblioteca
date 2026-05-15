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
    public partial class Estudiantes : Form
    {
        private int idEstSelec;
        private BindingList<Estudiante> listaEstudiantes = new BindingList<Estudiante>();
        public Estudiantes()
        {
            InitializeComponent();
            dgv_estudiantes.DataSource = listaEstudiantes;
        }

        private void Estudiantes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        public void CargarDatos()
        {
            CargarLista(Estudiante.ListarEstudiantes());
        }

        private void CargarLista(List<Estudiante> resultLista)
        {
            listaEstudiantes.Clear();
            foreach (Estudiante est in resultLista)
            {
                listaEstudiantes.Add(est);
            }
        }
        
        private void btn_crear_estudiantes_Click(object sender, EventArgs e)
        {
            CrearEstudiante crearEst = new CrearEstudiante();

            crearEst.Visible = true;
            this.Close();
        }

        private void btn_editar_estudiantes_Click(object sender, EventArgs e)
        {
            if(idEstSelec > 0)
            {
                EditarEstudiante editEst = new EditarEstudiante();
                editEst.Visible = true;
                editEst.CargarDatos(ref idEstSelec);
                this.Close();
            } else
            {
                MessageBox.Show("No se a seleccionado a ningun estudiante!", "Editar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void dgv_estudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idEstSelec = Convert.ToInt32(dgv_estudiantes.Rows[e.RowIndex].Cells[0].Value);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(cb_campos.Text != "")
            {
                string txtBuscar, campo;

                txtBuscar = txt_buscador.Text;
                campo = cb_campos.Text;

                CargarLista(Logica.Estudiante.Estudiante.Buscador(txtBuscar, campo));
                ep_categoria.SetError(cb_campos,"");
            }
            else
            {
                ep_categoria.SetError(cb_campos, "Ingrese una categoria!");
            }


        }

        private void btn_eliminar_estudiantes_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            bool resultado = false;

            if (idEstSelec > 0)
            {
                respuesta =  MessageBox.Show("Esta seguro que quiere eliminar este estudiante?\nEsta accion no se puede revertir", "Eliminar Estudiante", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    resultado = Logica.Estudiante.Estudiante.EliminarEstudiante(idEstSelec);
                    if(resultado)
                    {
                        MessageBox.Show("Se elimino el estudiante Exitosamente!", "Eliminar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ah ocurrido un error al intentar eliminar el estudiante", "Eliminar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se a seleccionado a ningun Estudiante!", "Eliminar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            CargarLista(Logica.Estudiante.Estudiante.ListarEstudiantes());
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
