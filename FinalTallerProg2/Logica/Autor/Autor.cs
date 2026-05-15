using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTallerProg2.Logica.Autor
{
    internal class Autor
    {
        private int idAutor { get; set; }
        private string nombre { get; set; }
        private string nacionalidad { get; set; }

        public int IdAutor
        {
            get { return idAutor; }
            set { idAutor = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }


        public static List<Autor> ListarAutores()
        {
            List<Autor> listA = new List<Autor>();

            Conexion conexion = new Conexion();
            
            try 
            {
                string query = "SELECT * FROM Autor";
                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    Autor aut = new Autor()
                    {
                        IdAutor = leer.GetInt32(0),
                        Nombre = leer.GetString(1),
                        Nacionalidad = leer.GetString(2),
                    };

                    listA.Add(aut);
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

            return listA;
        }

        public static bool CrearAutor(Autor aut)
        {
            bool estado = false;

            Conexion conexion = new Conexion();

            try
            {
                string query = "INSERT INTO Autor VALUES('" + aut.Nombre + "', '" + aut.Nacionalidad + "')";

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


        public static Autor BuscarAutorXId(int idAut)
        {
            Autor autor = new Autor();

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT * FROM Autor WHERE idAutor = " + idAut;

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());

                SqlDataReader resul = sql.ExecuteReader();

                if (resul.Read())
                {
                    autor.Nombre = resul.GetString(1);
                    autor.Nacionalidad = resul.GetString(2);
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
            return autor;

        }

        public static bool EditarAutor(Autor autorEditado)
        {
            bool resultado = false;

            Conexion conexion = new Conexion();

            try
            {
                string query = "UPDATE Autor SET Nombre = '" + autorEditado.Nombre + 
                    "', Nacionalidad = '" + autorEditado.Nacionalidad +
                    "' WHERE IdAutor = "+autorEditado.IdAutor;

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());

                if (sql.ExecuteNonQuery() > 0)
                {
                    resultado = true;
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

            return resultado;
        }

        public static bool EliminarAutor(int idAut)
        {
            bool respuesta = false;

            Conexion conexion = new Conexion();

            try
            {
                string query = "DELETE FROM Autor WHERE IdAutor = " + idAut;

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());

                if(sql.ExecuteNonQuery() > 0)
                {
                    respuesta = true;
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return respuesta;
        }

        public static List<Autor> Buscador (string txtBuscar, string categoria)
        {
            List<Autor> listaEncontrados = new List<Autor>();

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT * FROM Autor WHERE "+categoria+
                    " LIKE '"+txtBuscar+"%'";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                
                SqlDataReader result = sql.ExecuteReader();

                while (result.Read())
                {
                    Autor aut = new Autor();

                    aut.IdAutor = result.GetInt32(0);
                    aut.Nombre = result.GetString(1);
                    aut.Nacionalidad = result.GetString(2);

                    listaEncontrados.Add(aut);
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

        public static string NombreAutor(int idAut)
        {
            string nombreAut = "";

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT Nombre FROM Autor WHERE idAutor = " + idAut;

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());

                SqlDataReader resul = sql.ExecuteReader();

                if (resul.Read())
                {
                    nombreAut = resul.GetString(0);
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

            return nombreAut;
        }


    }
}

