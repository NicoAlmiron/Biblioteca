using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    // aca estan las consultas de las pantallas de inicio (las vistas vw_ de la bd)
    // antes estaban metidas directo en los forms, las pase a esta capa
    public class ResumenDatos
    {
        public static ResumenPrestamos ObtenerResumenPrestamos()
        {
            ResumenPrestamos resumen = new ResumenPrestamos();

            Conexion conexion = new Conexion();

            try
            {
                SqlCommand sql;
                SqlDataReader leer;

                // uso la misma conexion para todas, por eso cierro el reader antes de la siguiente
                sql = new SqlCommand("SELECT * FROM vw_PrestamosActivos", conexion.AbrirConexion());
                leer = sql.ExecuteReader();
                if (leer.Read()) resumen.PrestamosActivos = leer[0].ToString();
                leer.Close();

                sql = new SqlCommand("SELECT * FROM vw_PrestamosVencidos", conexion.AbrirConexion());
                leer = sql.ExecuteReader();
                if (leer.Read()) resumen.PrestamosVencidos = leer[0].ToString();
                leer.Close();

                sql = new SqlCommand("SELECT * FROM vw_PrestamosTotales", conexion.AbrirConexion());
                leer = sql.ExecuteReader();
                if (leer.Read()) resumen.PrestamosTotales = leer[0].ToString();
                leer.Close();

                sql = new SqlCommand("SELECT * FROM vw_LibroMasPrestado", conexion.AbrirConexion());
                leer = sql.ExecuteReader();
                if (leer.Read())
                {
                    resumen.LibroMasPrestado = leer[0].ToString();
                    if (leer.FieldCount > 1)
                        resumen.VecesLibroMasPrestado = leer[1].ToString();
                }
                leer.Close();

                sql = new SqlCommand("SELECT * FROM vw_LibroMenosPrestado", conexion.AbrirConexion());
                leer = sql.ExecuteReader();
                if (leer.Read()) resumen.LibroMenosPrestado = leer[0].ToString();
                leer.Close();

                sql = new SqlCommand("SELECT * FROM vw_AlumnoMasPrestamos", conexion.AbrirConexion());
                leer = sql.ExecuteReader();
                if (leer.Read())
                {
                    resumen.AlumnoMasPrestamos = leer[0].ToString();
                    if (leer.FieldCount > 1)
                        resumen.CantPrestamosAlumno = leer[1].ToString();
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

            return resumen;
        }

        public static ResumenLibros ObtenerResumenLibros()
        {
            ResumenLibros resumen = new ResumenLibros();

            Conexion conexion = new Conexion();

            try
            {
                SqlCommand sql;
                SqlDataReader leer;

                sql = new SqlCommand("SELECT * FROM vw_CantLibrosPrestados", conexion.AbrirConexion());
                leer = sql.ExecuteReader();
                if (leer.Read()) resumen.LibrosPrestados = leer[0].ToString();
                leer.Close();

                sql = new SqlCommand("SELECT * FROM vw_CantLibrosEnBiblioteca", conexion.AbrirConexion());
                leer = sql.ExecuteReader();
                if (leer.Read()) resumen.LibrosEnBiblioteca = leer[0].ToString();
                leer.Close();

                sql = new SqlCommand("SELECT * FROM vw_CantCategoriasDistintas", conexion.AbrirConexion());
                leer = sql.ExecuteReader();
                if (leer.Read()) resumen.CategoriasDistintas = leer[0].ToString();
                leer.Close();

                sql = new SqlCommand("SELECT * FROM vw_CantEditorialesDistintas", conexion.AbrirConexion());
                leer = sql.ExecuteReader();
                if (leer.Read()) resumen.EditorialesDistintas = leer[0].ToString();
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

            return resumen;
        }

        public static ResumenAutores ObtenerResumenAutores()
        {
            ResumenAutores resumen = new ResumenAutores();

            Conexion conexion = new Conexion();

            try
            {
                SqlCommand sql;
                SqlDataReader leer;

                sql = new SqlCommand("SELECT * FROM vw_CantAutoresRegistrados", conexion.AbrirConexion());
                leer = sql.ExecuteReader();
                if (leer.Read()) resumen.AutoresRegistrados = leer[0].ToString();
                leer.Close();

                sql = new SqlCommand("SELECT * FROM vw_MaxLibrosPorAutor", conexion.AbrirConexion());
                leer = sql.ExecuteReader();
                if (leer.Read()) resumen.MaxLibrosPorAutor = leer[0].ToString();
                leer.Close();

                sql = new SqlCommand("SELECT * FROM vw_MinLibrosPorAutor", conexion.AbrirConexion());
                leer = sql.ExecuteReader();
                if (leer.Read()) resumen.MinLibrosPorAutor = leer[0].ToString();
                leer.Close();

                sql = new SqlCommand("SELECT * FROM vw_NacionalidadMasComun", conexion.AbrirConexion());
                leer = sql.ExecuteReader();
                if (leer.Read()) resumen.NacionalidadMasComun = leer[0].ToString();
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

            return resumen;
        }

        public static ResumenEstudiantes ObtenerResumenEstudiantes()
        {
            ResumenEstudiantes resumen = new ResumenEstudiantes();

            Conexion conexion = new Conexion();

            try
            {
                SqlCommand sql;
                SqlDataReader leer;

                sql = new SqlCommand("SELECT * FROM vw_CantEstudiantesTotales", conexion.AbrirConexion());
                leer = sql.ExecuteReader();
                if (leer.Read()) resumen.EstudiantesTotales = leer[0].ToString();
                leer.Close();

                sql = new SqlCommand("SELECT * FROM vw_CarreraMayorEstudiantes", conexion.AbrirConexion());
                leer = sql.ExecuteReader();
                if (leer.Read()) resumen.CarreraMayorEstudiantes = leer[0].ToString();
                leer.Close();

                sql = new SqlCommand("SELECT * FROM vw_CarreraMenorEstudiantes", conexion.AbrirConexion());
                leer = sql.ExecuteReader();
                if (leer.Read()) resumen.CarreraMenorEstudiantes = leer[0].ToString();
                leer.Close();

                sql = new SqlCommand("SELECT * FROM vw_EstudianteMayorEdad", conexion.AbrirConexion());
                leer = sql.ExecuteReader();
                if (leer.Read()) resumen.EstudianteMayorEdad = leer[0].ToString();
                leer.Close();

                sql = new SqlCommand("SELECT * FROM vw_EstudianteMenorEdad", conexion.AbrirConexion());
                leer = sql.ExecuteReader();
                if (leer.Read()) resumen.EstudianteMenorEdad = leer[0].ToString();
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

            return resumen;
        }
    }
}
