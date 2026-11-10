using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    // estas clases las uso para las pantallas de inicio (las info)
    // guardo lo que devuelven las vistas vw_ de la bd, asi el form no tiene que tocar sql
    // lo dejo todo como string porque solo se muestra en los labels

    public class ResumenPrestamos
    {
        public string PrestamosActivos { get; set; }
        public string PrestamosVencidos { get; set; }
        public string PrestamosTotales { get; set; }
        public string LibroMasPrestado { get; set; }
        public string VecesLibroMasPrestado { get; set; }
        public string LibroMenosPrestado { get; set; }
        public string AlumnoMasPrestamos { get; set; }
        public string CantPrestamosAlumno { get; set; }
    }

    public class ResumenLibros
    {
        public string LibrosPrestados { get; set; }
        public string LibrosEnBiblioteca { get; set; }
        public string CategoriasDistintas { get; set; }
        public string EditorialesDistintas { get; set; }
    }

    public class ResumenAutores
    {
        public string AutoresRegistrados { get; set; }
        public string MaxLibrosPorAutor { get; set; }
        public string MinLibrosPorAutor { get; set; }
        public string NacionalidadMasComun { get; set; }
    }

    public class ResumenEstudiantes
    {
        public string EstudiantesTotales { get; set; }
        public string CarreraMayorEstudiantes { get; set; }
        public string CarreraMenorEstudiantes { get; set; }
        public string EstudianteMayorEdad { get; set; }
        public string EstudianteMenorEdad { get; set; }
    }
}
