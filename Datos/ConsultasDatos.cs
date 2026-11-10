using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    // consultas de la pantalla "Consultas" (son las mismas que estan en Documentacion/Consultas.sql)
    public class ConsultasDatos
    {
        // devuelve el SQL de la consulta elegida (numero del 1 al 15, igual que en el ListBox)
        public static string ObtenerConsulta(int numero)
        {
            string query = "";

            switch (numero)
            {
                case 1:
                    query = "SELECT A.IdAutor, A.Nombre, A.Nacionalidad, COUNT(*) AS CantidadLibros " +
                            "FROM Autor A INNER JOIN LibAut LA ON LA.IdAutor = A.IdAutor " +
                            "GROUP BY A.IdAutor, A.Nombre, A.Nacionalidad HAVING COUNT(*) > 1";
                    break;
                case 2:
                    query = "SELECT Nombre, Edad FROM Estudiante";
                    break;
                case 3:
                    query = "SELECT IdEstudiante, DNI, Nombre, Carrera FROM Estudiante WHERE Carrera LIKE 'Inform%tica'";
                    break;
                case 4:
                    // el apellido es lo que esta despues del primer espacio del nombre
                    query = "SELECT Nombre FROM Estudiante WHERE SUBSTRING(Nombre, CHARINDEX(' ', Nombre) + 1, 100) LIKE 'G%'";
                    break;
                case 5:
                    query = "SELECT A.Nombre FROM Autor A " +
                            "INNER JOIN LibAut LA ON LA.IdAutor = A.IdAutor " +
                            "INNER JOIN Libro L ON L.IdLibro = LA.IdLibro " +
                            "WHERE L.Titulo = 'Visual Studio Net'";
                    break;
                case 6:
                    query = "SELECT IdAutor, Nombre, Nacionalidad FROM Autor WHERE Nacionalidad IN ('USA', 'Francia')";
                    break;
                case 7:
                    query = "SELECT IdLibro, Titulo, Editorial, Area FROM Libro WHERE ISNULL(Area, '') <> 'Internet'";
                    break;
                case 8:
                    query = "SELECT L.Titulo, P.FechaPrestamo, P.FechaDevolucion FROM Prestamo P " +
                            "INNER JOIN Libro L ON L.IdLibro = P.Libro " +
                            "INNER JOIN Estudiante E ON E.IdEstudiante = P.Estudiante " +
                            "WHERE E.Nombre = 'Felipe Loayza Beramendi'";
                    break;
                case 9:
                    query = "SELECT Nombre, Edad FROM Estudiante WHERE Edad = (SELECT MIN(Edad) FROM Estudiante)";
                    break;
                case 10:
                    query = "SELECT DISTINCT E.Nombre FROM Prestamo P " +
                            "INNER JOIN Estudiante E ON E.IdEstudiante = P.Estudiante " +
                            "INNER JOIN Libro L ON L.IdLibro = P.Libro " +
                            "WHERE L.Area = 'Base de Datos'";
                    break;
                case 11:
                    query = "SELECT IdLibro, Titulo, Editorial, Area FROM Libro WHERE Editorial = 'Alfa y Omega'";
                    break;
                case 12:
                    query = "SELECT L.IdLibro, L.Titulo, L.Editorial, L.Area FROM Libro L " +
                            "INNER JOIN LibAut LA ON LA.IdLibro = L.IdLibro " +
                            "INNER JOIN Autor A ON A.IdAutor = LA.IdAutor " +
                            "WHERE A.Nombre = 'Mario Benedetti'";
                    break;
                case 13:
                    query = "SELECT L.Titulo, P.FechaDevolucion FROM Prestamo P " +
                            "INNER JOIN Libro L ON L.IdLibro = P.Libro " +
                            "WHERE P.FechaDevolucion = '2007-04-10'";
                    break;
                case 14:
                    query = "SELECT SUM(Edad) AS SumaEdades FROM Estudiante";
                    break;
                case 15:
                    // multiplico por 1.0 para que el promedio no se redondee a entero
                    query = "SELECT * FROM Estudiante WHERE Edad > (SELECT AVG(Edad * 1.0) FROM Estudiante)";
                    break;
            }

            return query;
        }

        // ejecuta la consulta y devuelve el resultado en un DataTable
        // uso DataTable y no una lista de entidades porque cada consulta trae columnas distintas,
        // y la grilla arma las columnas sola a partir del DataTable
        public static DataTable Ejecutar(int numero)
        {
            DataTable tabla = new DataTable();

            Conexion conexion = new Conexion();

            try
            {
                SqlCommand sql = new SqlCommand(ObtenerConsulta(numero), conexion.AbrirConexion());

                SqlDataReader leer = sql.ExecuteReader();

                // Load pasa todas las filas del reader al DataTable de una vez
                tabla.Load(leer);

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

            return tabla;
        }
    }
}
