using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    // capa de entidades: datos del prestamo
    public class Prestamo
    {

            public int IdPrestamo { get; set; }
            public string Libro { get; set; }
            public string Estudiante { get; set; }
            public DateTime FechaPrestamo { get; set; }
            // fecha limite para devolver el libro (puede venir NULL de la bd, por eso el ?)
            public DateTime? FechaDevolucion { get; set; }
            public bool Devuelto { get; set; }
            // los ids los dejo privados asi no aparecen como columnas en la grilla de prestamos
            private int idLibro { get; set; }
            private int idEstudiante { get; set; }



        public int IdEstudiante()
        {
            int idEst;
            idEst = idEstudiante;

            return idEst;
        }


        public int IdLibro()
        {
            int idLib;
            idLib = idLibro;
            return idLib;
        }

        public void CargaridEstidLib(int idEst, int idLib)
        {
            idEstudiante = idEst;
            idLibro = idLib;
        }
    }
}
