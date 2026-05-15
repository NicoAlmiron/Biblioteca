using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTallerProg2.Logica
{
    internal class Prestamo
    {

            public int IdPrestamo { get; set; }
            public string Libro { get; set; }
            public string Estudiante { get; set; }
            public DateTime FechaPrestamo { get; set; }
            public DateTime FechaDevolucion { get; set; }
            public bool Devuelto { get; set; }
            private int idLibro { get; set; }
            private int idEstudiante { get; set; }



        public int IdEstudiante()
        {
            int idEst;
            idEst = idEstudiante;

            return idEst;
        }

        
        public int IdLibro()
        {
            int idLib;
            idLib = idLibro;
            return idLib;
        }

        public static string ToFechaString(DateTime fecha, string tipo)
        {
            string fechaString = "";

            switch (tipo)
            {
                case "Estandar":
                    {

                        if (fecha.Month < 10)
                        {
                            fechaString += "0" + fecha.Month + "-";
                        }
                        else
                        {
                            fechaString += fecha.Month + "-";
                        }

                        if (fecha.Day < 10)
                        {
                            fechaString += "0" + fecha.Day + "-";
                        }
                        else
                        {
                            fechaString += fecha.Day + "-";
                        }

                        fechaString += fecha.Year;
                        break;
                    }
                case "SQL":
                    {
                        fechaString += fecha.Year + "-";

                        if (fecha.Month < 10)
                        {
                            fechaString += "0" + fecha.Month + "-";
                        }
                        else
                        {
                            fechaString += fecha.Month + "-";
                        }

                        if (fecha.Day < 10)
                        {
                            fechaString += "0" + fecha.Day;
                        }
                        else
                        {
                            fechaString += fecha.Day;
                        }
                        break;
                    }
                default:
                    {
                        if (fecha.Month < 10)
                        {
                            fechaString += "0" + fecha.Month + "-";
                        }
                        else
                        {
                            fechaString += fecha.Month + "-";
                        }

                        if (fecha.Day < 10)
                        {
                            fechaString += "0" + fecha.Day + "-";
                        }
                        else
                        {
                            fechaString += fecha.Day + "-";
                        }

                        fechaString += fecha.Year;
                        break;
                    }
            }
            return fechaString;
        }

        public void CargaridEstidLib(int idEst, int idLib)
        {
            idEstudiante = idEst;
            idLibro = idLib;
        }
        

        public static List<Prestamo> ListarPrestamos()
        {
            List<Prestamo> ListaPrestamos = new List<Prestamo>();

            Conexion conexion = new Conexion();

            try
            {

                string query = "SELECT * FROM ListarPrestamos";

                SqlCommand sql = new SqlCommand(query,conexion.AbrirConexion());

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    Prestamo item = new Prestamo()
                    {
                        IdPrestamo = leer.GetInt32(0),
                        Libro = leer.GetString(1),
                        Estudiante = leer.GetString(2),
                        FechaPrestamo = leer.GetDateTime(3),
                        FechaDevolucion = leer.GetDateTime(4),
                        Devuelto = leer.GetBoolean(5),
                    };
                    ListaPrestamos.Add(item);
                }

                leer.Close();

            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return ListaPrestamos;
        }

        public static bool CrearPrestamo(Prestamo prestamoNuevo)
        {
            bool result = false;
            string fechPres = "";
            string fechDev = "";

            fechPres = ToFechaString(prestamoNuevo.FechaPrestamo, "SQL");
            fechDev = ToFechaString(prestamoNuevo.FechaDevolucion, "SQL");

            Conexion conexion = new Conexion();

            try
            {

                string query = "INSERT INTO Prestamo VALUES ("
                    +prestamoNuevo.idEstudiante+","
                    +prestamoNuevo.idLibro+", '"
                    +fechPres+"', '"
                    +fechDev+"',"
                    +0+");";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());

                if(sql.ExecuteNonQuery() > 0)
                {
                    result = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }


            return result;

        }


    }
}
