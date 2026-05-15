using FinalTallerProg2.Vistas.Autores;
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
    public partial class AutoresInfo : Form
    {
        public AutoresInfo()
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

                cmd = new SqlCommand("SELECT * FROM vw_CantAutoresRegistrados", conx);
                reader = cmd.ExecuteReader();
                if (reader.Read()) label1.Text = "Cantidad de Autores Registrados: " + reader[0];
                reader.Close();

                cmd = new SqlCommand("SELECT * FROM vw_MaxLibrosPorAutor", conx);
                reader = cmd.ExecuteReader();
                if (reader.Read()) label2.Text = "Cantidad Maxima de Libros de un autor: " + reader[0];
                reader.Close();

                cmd = new SqlCommand("SELECT * FROM vw_MinLibrosPorAutor", conx);
                reader = cmd.ExecuteReader();
                if (reader.Read()) label4.Text = "Cantidad Minima de Libros de un autor: " + reader[0];
                reader.Close();

                cmd = new SqlCommand("SELECT * FROM vw_NacionalidadMasComun", conx);
                reader = cmd.ExecuteReader();
                if (reader.Read()) label5.Text = "Nacionalidad mas en comun: " + reader[0];
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
            Autores.Autores autores = new Autores.Autores();

            autores.Visible = true;
        }
    }
}
