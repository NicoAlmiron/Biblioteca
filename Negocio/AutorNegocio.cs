using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    // capa de negocio de autor
    // esta capa no toca sql, solo valida y le pasa las cosas a la capa de datos
    // los forms llaman a esta clase y nunca directo a Datos
    public class AutorNegocio
    {
        public static List<Autor> ListarAutores()
        {
            return AutorDatos.ListarAutores();
        }

        public static bool CrearAutor(Autor aut)
        {
            // el nombre es obligatorio en la bd, si viene vacio ni lo mando
            if (string.IsNullOrEmpty(aut.Nombre))
            {
                return false;
            }

            return AutorDatos.CrearAutor(aut);
        }

        public static Autor BuscarAutorXId(int idAut)
        {
            return AutorDatos.BuscarAutorXId(idAut);
        }

        public static bool EditarAutor(Autor autorEditado)
        {
            // si no tiene id o nombre no tiene sentido editar
            if (autorEditado.IdAutor <= 0 || string.IsNullOrEmpty(autorEditado.Nombre))
            {
                return false;
            }

            return AutorDatos.EditarAutor(autorEditado);
        }

        // si el autor tiene libros cargados en LibAut no se puede borrar
        public static bool TieneLibros(int idAut)
        {
            return AutorDatos.CantidadLibros(idAut) > 0;
        }

        public static bool EliminarAutor(int idAut)
        {
            if (idAut <= 0 || TieneLibros(idAut))
            {
                return false;
            }

            return AutorDatos.EliminarAutor(idAut);
        }

        public static List<Autor> Buscador(string txtBuscar, string categoria)
        {
            return AutorDatos.Buscador(txtBuscar, categoria);
        }

        public static string NombreAutor(int idAut)
        {
            return AutorDatos.NombreAutor(idAut);
        }
    }
}
