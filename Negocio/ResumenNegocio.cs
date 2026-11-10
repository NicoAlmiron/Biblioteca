using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    // negocio de las pantallas de inicio, por ahora solo le pide los datos a ResumenDatos
    // la dejo igual para que los forms no llamen directo a la capa de datos
    public class ResumenNegocio
    {
        public static ResumenPrestamos ObtenerResumenPrestamos()
        {
            return ResumenDatos.ObtenerResumenPrestamos();
        }

        public static ResumenLibros ObtenerResumenLibros()
        {
            return ResumenDatos.ObtenerResumenLibros();
        }

        public static ResumenAutores ObtenerResumenAutores()
        {
            return ResumenDatos.ObtenerResumenAutores();
        }

        public static ResumenEstudiantes ObtenerResumenEstudiantes()
        {
            return ResumenDatos.ObtenerResumenEstudiantes();
        }
    }
}
