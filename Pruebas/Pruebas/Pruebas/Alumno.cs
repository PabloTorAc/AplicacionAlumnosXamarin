using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Pruebas
{
    public class Alumno : Persona
    {

        //Atributos de la Clase Alumno
        public String Universidad { get; set; }
        public String Matricula { get; set; }
        public int Carrera { get; set; }
        public String NivelClase { get; set; }
        public ArrayList Materias { get; set; }


        //CONSTRUCTOR DE LA CLASE
        public Alumno()
        {
            Console.WriteLine("Comprobar de que entró en constructor de objeto Alumno");
        }

    }
}
