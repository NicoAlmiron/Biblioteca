using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    // capa de entidades: datos del libro
    public class Libro
    {
        private int idLibro { get; set; }
        private string titulo { get; set; }
        private string editorial { get; set; }
        private string autor { get; set; }
        private string area { get; set; }

        public int IdLibro
        {
            get { return idLibro; }
            set { idLibro = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Editorial
        {
            get { return editorial; }
            set { editorial = value; }
        }

        // nombres de los autores separados por coma, ej: "Bill Evjen, C. J. Date"
        // es solo para mostrar en la grilla (sale de la tabla LibAut)
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        // ids de los autores del libro (tabla LibAut), se usa para crear/editar
        // Browsable(false) hace que no aparezca como columna en el DataGridView
        [Browsable(false)]
        public List<int> IdAutores { get; set; } = new List<int>();

        public string Area
        {
            get { return area; }
            set { area = value; }
        }
    }
}
