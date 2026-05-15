using FinalTallerProg2.Vistas.Prestamos;
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
    public partial class PrestamoInfo : Form
    {
        public PrestamoInfo()
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

                cmd = new SqlCommand("SELECT * FROM vw_PrestamosActivos", conx);
                reader = cmd.ExecuteReader();
                if (reader.Read()) label1.Text = "- Cantidad de prestamos activos: " + reader[0];
                reader.Close();

                cmd = new SqlCommand("SELECT * FROM vw_PrestamosVencidos", conx);
                reader = cmd.ExecuteReader();
                if (reader.Read()) label2.Text = "- Cantidad de prestamos fuera de tiempo: " + reader[0];
                reader.Close();

                cmd = new SqlCommand("SELECT * FROM vw_PrestamosTotales", conx);
                reader = cmd.ExecuteReader();
                if (reader.Read()) label5.Text = "- Cantidad de prestamos totales: " + reader[0];
                reader.Close();

                cmd = new SqlCommand("SELECT * FROM vw_LibroMasPrestado", conx);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    label6.Text = "- Libro mas prestado: " + reader[0];
                    if (reader.FieldCount > 1)
                        label8.Text = "- Cantidad de veces prestado: " + reader[1];
                }
                reader.Close();

                cmd = new SqlCommand("SELECT * FROM vw_LibroMenosPrestado", conx);
                reader = cmd.ExecuteReader();
                if (reader.Read()) label7.Text = "- Libro menos prestado: " + reader[0];
                reader.Close();

                cmd = new SqlCommand("SELECT * FROM vw_AlumnoMasPrestamos", conx);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    label9.Text = "- Alumno con mas prestamos: " + reader[0];
                    if (reader.FieldCount > 1)
                        label10.Text = "- Cantidad de prestamos: " + reader[1];
                }
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
            PrestamosV prestamos = new PrestamosV();
            prestamos.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearPrestamo crearPrestamo = new CrearPrestamo();
            crearPrestamo.Visible = true;
        }
    }
}
