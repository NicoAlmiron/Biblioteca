using FinalTallerProg2.Vistas.Estudiantes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            Conexion con = new Conexion();
            SqlConnection conx = con.AbrirConexion();
            try
            {
                SqlCommand cmd;
                SqlDataReader reader;

                cmd = new SqlCommand("SELECT * FROM vw_CantEstudiantesTotales", conx);
                reader = cmd.ExecuteReader();
                if (reader.Read()) label1.Text = "- Cantidad de Estudiantes Totales: " + reader[0];
                reader.Close();

                cmd = new SqlCommand("SELECT * FROM vw_CarreraMayorEstudiantes", conx);
                reader = cmd.ExecuteReader();
                if (reader.Read()) label2.Text = "- Carrera con mayor cantidad de estudiantes: " + reader[0];
                reader.Close();

                cmd = new SqlCommand("SELECT * FROM vw_CarreraMenorEstudiantes", conx);
                reader = cmd.ExecuteReader();
                if (reader.Read()) label5.Text = "- Carrera con menor cantidad de estudiantes: " + reader[0];
                reader.Close();

                cmd = new SqlCommand("SELECT * FROM vw_EstudianteMayorEdad", conx);
                reader = cmd.ExecuteReader();
                if (reader.Read()) label6.Text = "- Estudiantes con mayor edad: " + reader[0];
                reader.Close();

                cmd = new SqlCommand("SELECT * FROM vw_EstudianteMenorEdad", conx);
                reader = cmd.ExecuteReader();
                if (reader.Read()) label7.Text = "- Estudiantes con menor edad: " + reader[0];
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
            finally
            {
                con.CerrarConexion();
            }
        }

        private void btn_estudiantes_Click(object sender, EventArgs e)
        {
            Estudiantes.Estudiantes estudiantes = new Estudiantes.Estudiantes();

            estudiantes.Visible = true;
        }
    }
}
