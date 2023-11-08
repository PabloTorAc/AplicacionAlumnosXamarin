using System;
using System.Collections.Generic;
using System.Text;

namespace Pruebas
{
    public class Docente : Persona
    {

        public String RFC { get; set; }
        public String Titulo { get; set; }
        public double Sueldo { get; set; }

        public Docente()
        {
            Console.WriteLine("Comprobación de que entró en constructor de objeto Docente");
        }

    }
}
