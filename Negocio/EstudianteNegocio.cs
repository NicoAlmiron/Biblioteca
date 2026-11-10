using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    // capa de negocio de estudiante: valida y llama a EstudianteDatos
    public class EstudianteNegocio
    {
        public static List<Estudiante> ListarEstudiantes()
        {
            return EstudianteDatos.ListarEstudiantes();
        }

        public static bool CrearEstudiante(Estudiante est)
        {
            // nombre y dni son obligatorios
            if (string.IsNullOrEmpty(est.Nombre) || string.IsNullOrEmpty(est.Dni))
            {
                return false;
            }

            return EstudianteDatos.CrearEstudiante(est);
        }

        public static Estudiante BuscarPorIdEstudiante(int idEst)
        {
            return EstudianteDatos.BuscarPorIdEstudiante(idEst);
        }

        public static List<Estudiante> Buscador(string txtABuscar, string campo)
        {
            return EstudianteDatos.Buscador(txtABuscar, campo);
        }

        public static bool EditarEstudiante(Estudiante estudiante)
        {
            // mismas reglas que al crear, y ademas tiene que tener id
            if (estudiante.IdEstudiante <= 0 ||
                string.IsNullOrEmpty(estudiante.Nombre) ||
                string.IsNullOrEmpty(estudiante.Dni))
            {
                return false;
            }

            return EstudianteDatos.EditarEstudiante(estudiante);
        }

        public static bool EliminarEstudiante(int idEst)
        {
            if (idEst <= 0)
            {
                return false;
            }

            return EstudianteDatos.EliminarEstudiante(idEst);
        }
    }
}
