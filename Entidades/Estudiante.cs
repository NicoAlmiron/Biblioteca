using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    // capa de entidades: datos del estudiante
    public class Estudiante
    {
        private int idEstudiante { get; set; }
        private string dni { get; set; }
        private string nombre { get; set; }
        private string direccion { get; set; }
        private string carrera { get; set; }
        private int edad { get; set; }


        public int IdEstudiante
        {
            get { return idEstudiante; }
            set { idEstudiante = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
    }
}
