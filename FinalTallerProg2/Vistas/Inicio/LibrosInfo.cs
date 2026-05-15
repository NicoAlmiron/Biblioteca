using FinalTallerProg2.Vistas.Libros;
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
    public partial class LibrosInfo : Form
    {
        public LibrosInfo()
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

                cmd = new SqlCommand("SELECT * FROM vw_CantLibrosPrestados", conx);
                reader = cmd.ExecuteReader();
                if (reader.Read()) label2.Text = "- Cantidad de Libros Prestados: " + reader[0];
                reader.Close();

                cmd = new SqlCommand("SELECT * FROM vw_CantLibrosEnBiblioteca", conx);
                reader = cmd.ExecuteReader();
                if (reader.Read()) label3.Text = "- Cantidad de Entidades en la biblioteca: " + reader[0];
                reader.Close();

                cmd = new SqlCommand("SELECT * FROM vw_CantCategoriasDistintas", conx);
                reader = cmd.ExecuteReader();
                if (reader.Read()) label1.Text = "- Cantidad Categorias Distintas: " + reader[0];
                reader.Close();

                cmd = new SqlCommand("SELECT * FROM vw_CantEditorialesDistintas", conx);
                reader = cmd.ExecuteReader();
                if (reader.Read()) label5.Text = "- Cantidad Editoriales Distintas: " + reader[0];
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

        private void btn_libros_Click(object sender, EventArgs e)
        {
            Libros.Libros ventanaLibro = new Libros.Libros();

            ventanaLibro.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
