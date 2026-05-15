using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTallerProg2.Logica.Libro
{
    internal class Libro
    {
        private int idLibro { get; set; }
        private string titulo { get; set; }
        private string editorial { get; set; }
        private string autor { get; set; }
        private string area { get; set; }

        public int IdLibro
        {
            get { return idLibro; }
            set { idLibro = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Editorial
        {
            get { return editorial; }
            set { editorial = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public string Area
        {
            get { return area; }
            set { area = value; }
        }

        public static List<Libro> ListarLibros()
        {
            List<Libro> listaL = new List<Libro>();

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT * FROM sp_ListarLibros";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());

                SqlDataReader leer = sql.ExecuteReader();

                while(leer.Read())
                {
                    Libro lib = new Libro()
                    {
                        IdLibro = leer.GetInt32(0),
                        Titulo = leer.GetString(1),
                        Editorial = leer.GetString(2),
                        Autor = leer.GetString(3),
                        Area = leer.GetString(4),
                    };

                    listaL.Add(lib);
                }

                leer.Close();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return listaL;
        }

        public static bool CrearLibro(Libro libro)
        {
            bool result = false;

            Conexion conexion = new Conexion();

            try
            {
                string query = "INSERT INTO Libro VALUES ('"+
                    libro.Titulo +"', '"+
                    libro.Editorial +"', '"+
                    libro.Area +"', "+
                    int.Parse(libro.Autor) +")";

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

        public static Libro ObtenerLibroId(int idLibro)
        {
            Libro libro = new Libro();

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT * FROM Libro WHERE IdLibro = " + idLibro;

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    libro.Titulo = leer.GetString(1);
                    libro.Editorial = leer.GetString(2);
                    libro.Area = leer.GetString(3);
                    libro.Autor = leer.GetInt32(4).ToString();
                }

                leer.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return libro;

        }


        public static bool EditarLibro(Libro lib)
        {
            bool estado = false;

            Conexion conexion = new Conexion();

            try
            {
                 string query = "UPDATE Libro SET " +
                    "Titulo = '" + lib.Titulo +
                    "', Editorial = '" + lib.Editorial +
                    "', Area = '" + lib.Area + 
                    "', Autor = " + Convert.ToInt32(lib.Autor) +
                    " WHERE IdLibro = " + lib.IdLibro;

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

        public static List<Libro> Buscador (string txtBuscar, string campo)
        {
            List<Libro> libros = new List<Libro>();

            Conexion conexion = new Conexion ();

            try
            {
                string query = "SELECT L.IdLibro, L.Titulo, L.Editorial, L.Area, A.Nombre AS Autor FROM Libro L " +
                                "INNER JOIN Autor A ON A.IdAutor = L.Autor WHERE L." + campo + " LIKE '" + txtBuscar + "%'";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());

                SqlDataReader leer = sql.ExecuteReader();

                while(leer.Read())
                {
                    Libro lib = new Libro ();

                    lib.IdLibro = leer.GetInt32(0);
                    lib.Titulo = leer.GetString(1);
                    lib.Editorial = leer.GetString(2);
                    lib.Area = leer.GetString(3);
                    lib.Autor = leer.GetString(4);

                    libros.Add(lib);
                }
                leer.Close();
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return libros;
        }

        public static List<Libro> BuscarPorAutor(string autores)
        {
            List<Libro> libros = new List<Libro>();

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT L.IdLibro, L.Titulo, L.Editorial, L.Area, A.Nombre AS Autor FROM Libro L " +
                                "INNER JOIN Autor A ON A.IdAutor = L.Autor WHERE L.Autor IN (" + autores+")";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    Libro lib = new Libro();

                    lib.IdLibro = leer.GetInt32(0);
                    lib.Titulo = leer.GetString(1);
                    lib.Editorial = leer.GetString(2);
                    lib.Area = leer.GetString(3);
                    lib.Autor = leer.GetString(4);

                    libros.Add(lib);
                }
                leer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return libros;
        }

        public static bool EliminarLibro(int idLibro)
        {
            bool estado = false;

            Conexion conexion = new Conexion();

            try
            {
                string query = "DELETE FROM Libro WHERE idLibro = " + idLibro;

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
