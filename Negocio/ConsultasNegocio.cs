using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    // capa de negocio de la pantalla de consultas
    public class ConsultasNegocio
    {
        public static string ObtenerConsulta(int numero)
        {
            return ConsultasDatos.ObtenerConsulta(numero);
        }

        public static DataTable Ejecutar(int numero)
        {
            // solo hay consultas del 1 al 15, si viene otro numero devuelvo una tabla vacia
            if (numero < 1 || numero > 15)
            {
                return new DataTable();
            }

            return ConsultasDatos.Ejecutar(numero);
        }
    }
}
