using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    // capa de negocio de libro: valida y llama a LibroDatos
    public class LibroNegocio
    {
        public static List<Libro> ListarLibros()
        {
            return LibroDatos.ListarLibros();
        }

        public static bool CrearLibro(Libro libro)
        {
            // el titulo es obligatorio y tiene que tener al menos un autor elegido
            if (string.IsNullOrEmpty(libro.Titulo) || !AutoresValidos(libro.IdAutores))
            {
                return false;
            }

            return LibroDatos.CrearLibro(libro);
        }

        public static Libro ObtenerLibroId(int idLibro)
        {
            return LibroDatos.ObtenerLibroId(idLibro);
        }

        public static bool EditarLibro(Libro lib)
        {
            if (lib.IdLibro <= 0 || string.IsNullOrEmpty(lib.Titulo) || !AutoresValidos(lib.IdAutores))
            {
                return false;
            }

            return LibroDatos.EditarLibro(lib);
        }

        public static List<Libro> Buscador(string txtBuscar, string campo)
        {
            return LibroDatos.Buscador(txtBuscar, campo);
        }

        // busca los libros por el nombre de alguno de sus autores (la consulta pasa por LibAut)
        public static List<Libro> BuscarPorNombreAutor(string txtBuscar)
        {
            return LibroDatos.BuscarPorNombreAutor(txtBuscar);
        }

        // un libro con prestamos registrados no se puede borrar (lo usa la pantalla para avisar)
        public static bool TienePrestamos(int idLibro)
        {
            return LibroDatos.CantidadPrestamos(idLibro) > 0;
        }

        public static bool EliminarLibro(int idLibro)
        {
            if (idLibro <= 0 || TienePrestamos(idLibro))
            {
                return false;
            }

            return LibroDatos.EliminarLibro(idLibro);
        }

        // tiene que haber al menos un autor y todos los ids tienen que ser mayores a 0
        private static bool AutoresValidos(List<int> idAutores)
        {
            return idAutores != null && idAutores.Count > 0 && idAutores.All(id => id > 0);
        }
    }
}
