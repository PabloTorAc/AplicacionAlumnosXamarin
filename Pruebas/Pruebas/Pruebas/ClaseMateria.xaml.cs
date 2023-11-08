using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pruebas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClaseMateria : ContentPage
    {

        Alumno AlumnoUno;
        Alumno AlumnoDos = new Alumno();
        Alumno AlumnoTres = new Alumno();

        ArrayList Temas_Materia = new ArrayList();

        public ClaseMateria()
        {
            InitializeComponent();

            AlumnoUno.Matricula = "0001";
            AlumnoUno.Nombre = "Alejandra Montessori Virrey";
            AlumnoUno.Carrera = 3;
            AlumnoUno.Domicilio = "Torrente #315";
            AlumnoUno.NivelClase = "2";

            AlumnoDos.Matricula = "0002";
            AlumnoDos.Nombre = "Pablo";
            AlumnoDos.Carrera = 1;
            AlumnoDos.Domicilio = "Torrente #315";
            AlumnoDos.NivelClase = "2";

            AlumnoTres.Matricula = "0003";
            AlumnoTres.Nombre = "Diana López Sánchez";
            AlumnoTres.Carrera = 2;
            AlumnoTres.Domicilio = "Rio #477";
            AlumnoTres.NivelClase = "7";

        }

        async void Regreso(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void MetodoGuardarMateria(object sender, EventArgs e)
        {

            try
            {
                String idMateria = IdEntry.Text;
                String nombreMateria = NombreEntry.Text;
                String calificacion = CalificacionEntry.Text;
                String nivelClase = NivelEntry.Text;
                int indexAlumnos = pickerAlumno.SelectedIndex;
                String profesor = ProfesorEntry.Text;
                String programaEducativo = ProgramaEntry.Text;

                MateriaUCQ m = new MateriaUCQ();

                m.IdMateria = idMateria;
                m.NombreMateria = nombreMateria;
                m.Calificacion = calificacion;
                m.NivelClase = nivelClase;
                m.Profesor = profesor;
                m.ProgramaEducativo = programaEducativo;

                Console.WriteLine(" ID GUARDADO: " + m.IdMateria);
                Console.WriteLine(" NOMBRE GUARDADO: " + m.NombreMateria);
                Console.WriteLine(" CALIFICACIÓN GUARDADA: " + m.Calificacion);
                Console.WriteLine(" NIVEL GUARDADO: " + m.NivelClase);
                Console.WriteLine(" PROFESOR GUARDADO: " + m.Profesor);
                Console.WriteLine(" PROGRAMA GUARDADO: " + m.ProgramaEducativo);

                AlumnoUno =new Alumno();

                AlumnoUno.Materias.Add(m);

                /* switch (indexAlumnos)
                 {
                     case 0:
                         Console.WriteLine("Comprobación de entrada");
                         AlumnoUno.Materias.Add(m);
                         break;
                     case 1:
                         AlumnoDos.Materias.Add(m);
                         break;
                     case 2:
                         AlumnoTres.Materias.Add(m);
                         break;
                 }*/

                /*if (indexAlumnos == 0)
                {
                    Console.WriteLine("Comprobación de entrada");
                    AlumnoUno.Materias.Add(m);

                }else if (indexAlumnos == 1)
                {
                    Console.WriteLine("Comprobación de entrada");
                    AlumnoDos.Materias.Add(m);
                }else if (indexAlumnos == 2)
                {
                    Console.WriteLine("Comprobación de entrada");
                    AlumnoTres.Materias.Add(m);
                }*/
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exepcion: "+ex.ToString());
            }

            

        }

        async void MetodoMostrarMateria(object sender, EventArgs e)
        {

        }
    }
}