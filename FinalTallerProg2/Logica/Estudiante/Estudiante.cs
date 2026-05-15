using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTallerProg2.Logica.Estudiante
{
    internal class Estudiante
    {
        private int idEstudiante { get; set; }
        private string dni { get; set; }
        private string nombre { get; set; }
        private string direccion { get; set; }
        private string carrera { get; set; }
        private int edad { get; set; }


        public int IdEstudiante
        {
            get { return idEstudiante; }
            set { idEstudiante = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public static List<Estudiante> ListarEstudiantes()
        {
            List<Estudiante> ListaEst = new List<Estudiante>();

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT * FROM Estudiante";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());

                SqlDataReader leer = sql.ExecuteReader();

                while(leer.Read())
                {
                    Estudiante est = new Estudiante()
                    {
                        IdEstudiante = leer.GetInt32(0),
                        Dni = leer.GetString(1),
                        Nombre = leer.GetString(2),
                        Direccion = leer.GetString(3),
                        Carrera = leer.GetString(4),
                        Edad = leer.GetInt32(5)
                    };
                    ListaEst.Add(est);
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

            return ListaEst;
        }

        public static bool CrearEstudiante(Estudiante est)
        {
            bool estado = false;

            Conexion conexion = new Conexion();

            try
            {
                string query = "INSERT INTO Estudiante VALUES('" + est.Dni + "', '" + est.Nombre + "', '" + est.Direccion + "', '" + est.Carrera + "', " + est.Edad + ")";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());

                if (sql.ExecuteNonQuery() > 0)
                {
                    estado = true;
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

            return estado;

        }

        public static Estudiante BuscarPorIdEstudiante(int idEst)
        {
            Estudiante estudiante = new Estudiante();

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT * FROM Estudiante WHERE IdEstudiante = " + idEst;

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());

                SqlDataReader resul = sql.ExecuteReader();

                if (resul.Read())
                {
                    estudiante.IdEstudiante = resul.GetInt32(0);
                    estudiante.Dni = resul.GetString(1);
                    estudiante.Nombre = resul.GetString(2);
                    estudiante.Direccion = resul.GetString(3);
                    estudiante.Carrera = resul.GetString(4);
                    estudiante.Edad = resul.GetInt32(5);
                }

                resul.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return estudiante;

        }

        public static List<Estudiante> Buscador(string txtABuscar, string campo)
        {
            List<Estudiante> listaEncontrados = new List<Estudiante>();

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT * FROM Estudiante WHERE " + campo + " LIKE '%" + txtABuscar + "%'";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());

                SqlDataReader result = sql.ExecuteReader();

                while (result.Read())
                {
                    Estudiante est = new Estudiante();

                    est.IdEstudiante = result.GetInt32(0);
                    est.Dni = result.GetString(1);
                    est.Nombre = result.GetString(2);
                    est.Direccion = result.GetString(3);
                    est.Carrera = result.GetString(4);
                    est.Edad = result.GetInt32(5);

                    listaEncontrados.Add(est);
                }
                result.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return listaEncontrados;

        }

        public static bool EditarEstudiante(Estudiante estudiante)
        {
            bool estado = false;

            Conexion conexion = new Conexion();

            try
            {

                string query = "UPDATE Estudiante SET Nombre = '"+estudiante.Nombre +
                               "', Direccion = '" + estudiante.Direccion +
                               "', Carrera = '" + estudiante.Carrera +
                               "', DNI = '" + estudiante.Dni +
                               "', Edad = "+ estudiante.Edad +
                               "WHERE IdEstudiante = " + estudiante.IdEstudiante;

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());

                if (sql.ExecuteNonQuery() > 0)
                {
                    estado = true;
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


            return estado;

        }


        public static bool EliminarEstudiante(int idEst)
        {
            bool estado = false;

            Conexion conexion = new Conexion();

            try
            {
                string query = "DELETE FROM Estudiante WHERE IdEstudiante = " + idEst;

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());

                if(sql.ExecuteNonQuery() > 0)
                {
                    estado = true;
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

            return estado;
        }

    }
}
