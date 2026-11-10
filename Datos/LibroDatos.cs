using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    // capa de datos de libro: consultas a las tablas Libro y LibAut (y la vista sp_ListarLibros)
    // un libro puede tener varios autores, por eso los autores se guardan en LibAut
    public class LibroDatos
    {
        // columnas por las que se puede buscar (las uso como lista blanca para armar el WHERE)
        private static readonly string[] camposBusqueda = { "IdLibro", "Titulo", "Editorial", "Area" };

        // la vista devuelve: IdLibro, Titulo, Editorial, Autores, Area
        private static Libro LeerLibroDeVista(SqlDataReader leer)
        {
            Libro lib = new Libro()
            {
                IdLibro = leer.GetInt32(0),
                Titulo = leer.GetString(1),
                Editorial = leer.GetString(2),
                Autor = leer.GetString(3),
                Area = leer.GetString(4),
            };
            return lib;
        }

        // uso la vista sp_ListarLibros porque ya trae los nombres de los autores juntos
        public static List<Libro> ListarLibros()
        {
            List<Libro> listaL = new List<Libro>();

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT * FROM sp_ListarLibros";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    listaL.Add(LeerLibroDeVista(leer));
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

            return listaL;
        }

        // inserta en LibAut una fila por cada autor del libro
        private static void InsertarAutores(int idLibro, List<int> idAutores, SqlConnection con, SqlTransaction tran)
        {
            foreach (int idAutor in idAutores)
            {
                SqlCommand sql = new SqlCommand("INSERT INTO LibAut (IdAutor, IdLibro) VALUES (@idAutor, @idLibro)", con, tran);
                sql.Parameters.AddWithValue("@idAutor", idAutor);
                sql.Parameters.AddWithValue("@idLibro", idLibro);
                sql.ExecuteNonQuery();
            }
        }

        // crea el libro y sus autores en una transaccion:
        // si falla algun insert no queda un libro sin autores
        public static bool CrearLibro(Libro libro)
        {
            bool result = false;

            Conexion conexion = new Conexion();
            SqlTransaction tran = null;

            try
            {
                SqlConnection con = conexion.AbrirConexion();
                tran = con.BeginTransaction();

                // OUTPUT INSERTED.IdLibro me devuelve el id que genero el IDENTITY
                string query = "INSERT INTO Libro (Titulo, Editorial, Area) OUTPUT INSERTED.IdLibro " +
                               "VALUES (@titulo, @editorial, @area)";

                SqlCommand sql = new SqlCommand(query, con, tran);
                sql.Parameters.AddWithValue("@titulo", libro.Titulo);
                sql.Parameters.AddWithValue("@editorial", libro.Editorial ?? "");
                sql.Parameters.AddWithValue("@area", libro.Area ?? "");

                int idNuevo = (int)sql.ExecuteScalar();

                InsertarAutores(idNuevo, libro.IdAutores, con, tran);

                tran.Commit();
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (tran != null) tran.Rollback();
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
                string query = "SELECT IdLibro, Titulo, ISNULL(Editorial, ''), ISNULL(Area, '') FROM Libro WHERE IdLibro = @id";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@id", idLibro);

                SqlDataReader leer = sql.ExecuteReader();

                if (leer.Read())
                {
                    libro.IdLibro = leer.GetInt32(0);
                    libro.Titulo = leer.GetString(1);
                    libro.Editorial = leer.GetString(2);
                    libro.Area = leer.GetString(3);
                }
                leer.Close();

                // despues traigo los autores que tiene en LibAut
                sql = new SqlCommand("SELECT IdAutor FROM LibAut WHERE IdLibro = @id", conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@id", idLibro);

                leer = sql.ExecuteReader();
                while (leer.Read())
                {
                    libro.IdAutores.Add(leer.GetInt32(0));
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

        // actualiza los datos del libro y reemplaza sus autores (borro los de LibAut y cargo los nuevos)
        public static bool EditarLibro(Libro lib)
        {
            bool estado = false;

            Conexion conexion = new Conexion();
            SqlTransaction tran = null;

            try
            {
                SqlConnection con = conexion.AbrirConexion();
                tran = con.BeginTransaction();

                string query = "UPDATE Libro SET Titulo = @titulo, Editorial = @editorial, Area = @area WHERE IdLibro = @id";

                SqlCommand sql = new SqlCommand(query, con, tran);
                sql.Parameters.AddWithValue("@titulo", lib.Titulo);
                sql.Parameters.AddWithValue("@editorial", lib.Editorial ?? "");
                sql.Parameters.AddWithValue("@area", lib.Area ?? "");
                sql.Parameters.AddWithValue("@id", lib.IdLibro);

                if (sql.ExecuteNonQuery() > 0)
                {
                    SqlCommand borrar = new SqlCommand("DELETE FROM LibAut WHERE IdLibro = @id", con, tran);
                    borrar.Parameters.AddWithValue("@id", lib.IdLibro);
                    borrar.ExecuteNonQuery();

                    InsertarAutores(lib.IdLibro, lib.IdAutores, con, tran);

                    tran.Commit();
                    estado = true;
                }
                else
                {
                    tran.Rollback();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (tran != null) tran.Rollback();
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return estado;
        }

        // busca en la vista por la columna elegida (Titulo, Editorial, Area o IdLibro)
        public static List<Libro> Buscador(string txtBuscar, string campo)
        {
            List<Libro> libros = new List<Libro>();

            // si me pasan una columna que no existe no busco nada (evita SQL injection en el nombre de la columna)
            if (!camposBusqueda.Contains(campo))
            {
                return libros;
            }

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT * FROM sp_ListarLibros WHERE " + campo + " LIKE @texto + '%'";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@texto", txtBuscar);

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    libros.Add(LeerLibroDeVista(leer));
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

        // libros que tengan algun autor cuyo nombre empiece con el texto (pasa por LibAut)
        public static List<Libro> BuscarPorNombreAutor(string nombreAutor)
        {
            List<Libro> libros = new List<Libro>();

            Conexion conexion = new Conexion();

            try
            {
                string query = "SELECT * FROM sp_ListarLibros WHERE IdLibro IN (" +
                               "SELECT LA.IdLibro FROM LibAut LA " +
                               "INNER JOIN Autor A ON A.IdAutor = LA.IdAutor " +
                               "WHERE A.Nombre LIKE @nombre + '%')";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@nombre", nombreAutor);

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    libros.Add(LeerLibroDeVista(leer));
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

        // cuantos prestamos tiene registrados el libro (si tiene, no se puede borrar por la FK)
        public static int CantidadPrestamos(int idLibro)
        {
            int cantidad = 0;

            Conexion conexion = new Conexion();

            try
            {
                SqlCommand sql = new SqlCommand("SELECT COUNT(*) FROM Prestamo WHERE Libro = @id", conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@id", idLibro);

                cantidad = (int)sql.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return cantidad;
        }

        // primero borro las filas de LibAut (sino la FK no deja borrar el libro)
        public static bool EliminarLibro(int idLibro)
        {
            bool estado = false;

            Conexion conexion = new Conexion();
            SqlTransaction tran = null;

            try
            {
                SqlConnection con = conexion.AbrirConexion();
                tran = con.BeginTransaction();

                SqlCommand borrarAutores = new SqlCommand("DELETE FROM LibAut WHERE IdLibro = @id", con, tran);
                borrarAutores.Parameters.AddWithValue("@id", idLibro);
                borrarAutores.ExecuteNonQuery();

                SqlCommand sql = new SqlCommand("DELETE FROM Libro WHERE IdLibro = @id", con, tran);
                sql.Parameters.AddWithValue("@id", idLibro);

                if (sql.ExecuteNonQuery() > 0)
                {
                    tran.Commit();
                    estado = true;
                }
                else
                {
                    tran.Rollback();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (tran != null) tran.Rollback();
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return estado;
        }
    }
}
