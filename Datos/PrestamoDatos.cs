using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    // capa de datos de prestamo: consultas a la tabla Prestamo y la vista ListarPrestamos
    public class PrestamoDatos
    {
        public static List<Prestamo> ListarPrestamos()
        {
            List<Prestamo> ListaPrestamos = new List<Prestamo>();

            Conexion conexion = new Conexion();

            try
            {
                // ordeno para que los mas nuevos aparezcan primero
                string query = "SELECT * FROM ListarPrestamos ORDER BY FechaPrestamo DESC, IdPrestamo DESC";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());

                SqlDataReader leer = sql.ExecuteReader();

                while (leer.Read())
                {
                    Prestamo item = new Prestamo()
                    {
                        IdPrestamo = leer.GetInt32(0),
                        Libro = leer.GetString(1),
                        Estudiante = leer.GetString(2),
                        FechaPrestamo = leer.GetDateTime(3),
                        // la fecha limite puede ser NULL, si lo es la dejo vacia (antes esto cortaba la lista)
                        FechaDevolucion = leer.IsDBNull(4) ? (DateTime?)null : leer.GetDateTime(4),
                        Devuelto = leer.GetBoolean(5),
                    };
                    ListaPrestamos.Add(item);
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

            return ListaPrestamos;
        }

        public static bool CrearPrestamo(Prestamo prestamoNuevo)
        {
            bool result = false;

            Conexion conexion = new Conexion();

            try
            {
                // Devuelto = 0 porque recien se presta
                // con parametros le paso las fechas como DateTime y no tengo que armar el texto "yyyy-MM-dd"
                string query = "INSERT INTO Prestamo (Estudiante, Libro, FechaPrestamo, FechaDevolucion, Devuelto) " +
                               "VALUES (@estudiante, @libro, @fechaPrestamo, @fechaDevolucion, 0)";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@estudiante", prestamoNuevo.IdEstudiante());
                sql.Parameters.AddWithValue("@libro", prestamoNuevo.IdLibro());
                sql.Parameters.AddWithValue("@fechaPrestamo", prestamoNuevo.FechaPrestamo.Date);
                sql.Parameters.AddWithValue("@fechaDevolucion", (object)prestamoNuevo.FechaDevolucion ?? DBNull.Value);

                if (sql.ExecuteNonQuery() > 0)
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

        // marca el prestamo como devuelto
        // FechaDevolucion no se toca porque es la fecha limite que se pacto al prestar
        // el "AND Devuelto = 0" hace que si ya estaba devuelto no se modifique nada (devuelve false)
        public static bool MarcarDevuelto(int idPrestamo)
        {
            bool result = false;

            Conexion conexion = new Conexion();

            try
            {
                string query = "UPDATE Prestamo SET Devuelto = 1 WHERE IdPrestamo = @id AND Devuelto = 0";

                SqlCommand sql = new SqlCommand(query, conexion.AbrirConexion());
                sql.Parameters.AddWithValue("@id", idPrestamo);

                if (sql.ExecuteNonQuery() > 0)
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
