using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    // capa de entidades: aca solo van los datos del autor, nada de sql ni logica
    public class Autor
    {
        private int idAutor { get; set; }
        private string nombre { get; set; }
        private string nacionalidad { get; set; }

        public int IdAutor
        {
            get { return idAutor; }
            set { idAutor = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }
    }
}
