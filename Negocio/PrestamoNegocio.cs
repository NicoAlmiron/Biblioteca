using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    // capa de negocio de prestamo: valida y llama a PrestamoDatos
    public class PrestamoNegocio
    {
        public static List<Prestamo> ListarPrestamos()
        {
            return PrestamoDatos.ListarPrestamos();
        }

        public static bool CrearPrestamo(Prestamo prestamoNuevo)
        {
            // tiene que tener estudiante y libro
            if (prestamoNuevo.IdEstudiante() <= 0 || prestamoNuevo.IdLibro() <= 0)
            {
                return false;
            }

            // la fecha limite es obligatoria y no puede ser anterior al dia del prestamo
            if (prestamoNuevo.FechaDevolucion == null ||
                prestamoNuevo.FechaDevolucion.Value.Date < prestamoNuevo.FechaPrestamo.Date)
            {
                return false;
            }

            return PrestamoDatos.CrearPrestamo(prestamoNuevo);
        }

        // devuelve false si el prestamo no existe o ya estaba devuelto
        public static bool Devolver(int idPrestamo)
        {
            if (idPrestamo <= 0)
            {
                return false;
            }

            return PrestamoDatos.MarcarDevuelto(idPrestamo);
        }

        // filtra la lista que ya tengo cargada, asi no consulto la bd cada vez que se escribe una letra
        // campo: "Titulo" o "Estudiante"
        public static List<Prestamo> Filtrar(List<Prestamo> prestamos, string texto, string campo, bool soloPendientes)
        {
            IEnumerable<Prestamo> resultado = prestamos;

            if (!string.IsNullOrWhiteSpace(texto))
            {
                string buscado = texto.Trim().ToLower();

                if (campo == "Estudiante")
                {
                    resultado = resultado.Where(p => p.Estudiante.ToLower().Contains(buscado));
                }
                else
                {
                    resultado = resultado.Where(p => p.Libro.ToLower().Contains(buscado));
                }
            }

            if (soloPendientes)
            {
                resultado = resultado.Where(p => !p.Devuelto);
            }

            return resultado.ToList();
        }
    }
}
