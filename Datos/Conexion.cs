using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    // esta clase es la unica que sabe donde esta la bd
    // la uso desde todas las clases de la capa de datos para abrir y cerrar la conexion
    public class Conexion
    {
        private string conString = "Server=localhost\\SQLEXPRESS;Database=bibliotecabd;Trusted_Connection=True;";
        private SqlConnection conx;

        public Conexion()
        {
            conx = new SqlConnection(conString);
        }

        public SqlConnection AbrirConexion()
        {
            if (conx.State == ConnectionState.Closed)
            {
                conx.Open();
            }
            return conx;
        }

        public void CerrarConexion()
        {
            if (conx.State == ConnectionState.Open)
            {
                conx.Close();
            }
        }
    }

}
