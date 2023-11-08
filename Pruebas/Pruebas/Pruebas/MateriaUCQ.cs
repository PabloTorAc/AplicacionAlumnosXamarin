using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Pruebas
{
    public class MateriaUCQ
    {
        public String IdMateria { get; set; }
        public String NombreMateria { get; set; }
        public String Calificacion { get; set; }
        public String NivelClase { get; set; }
        public ArrayList Alumnos { get; set; }
        public String ProgramaEducativo { get; set; }
        public String Profesor {  get; set; }

        public MateriaUCQ()
        {
            Console.WriteLine("Comprobación de que entró en constructor de objeto Materia");
        }

    }
}
