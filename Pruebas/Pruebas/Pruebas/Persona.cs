using System;
using System.Collections.Generic;
using System.Text;

namespace Pruebas
{
    public class Persona
    {

        public String Nombre { get; set; }
        public String ApellidoPaterno { get; set; }
        public String ApellidoMaterno { get; set; }
        public int Edad { get; set; }
        public String Sexo { get; set; }
        public String Domicilio { get; set; }


        //CONSTRUCTOR DE LA CLASE
        public Persona()
        {
            Console.WriteLine("Comprobar de que entró en constructor de objeto Persona");
        }

    }
}
