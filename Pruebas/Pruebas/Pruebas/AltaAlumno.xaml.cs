using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pruebas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AltaAlumno : ContentPage
    {

        HttpClient client;

        Alumno a1 { get; set; }
        Alumno a2 { get; set; }
        Alumno a3 { get; set; }
        Alumno a4 { get; set; }
        Alumno a5 { get; set; }

        MateriaUCQ m1 { get; set; }
        MateriaUCQ m2 { get; set; }
        MateriaUCQ m3 { get; set; }

        public ArrayList AlumnosUCQArray = new ArrayList();

        int selectedIndexCarrera = 0;
        int selectedIndexAlumno = 0;

        public AltaAlumno()
        {
            InitializeComponent();
            a1 = new Alumno();
            a2 = new Alumno();
            a3 = new Alumno();
            a4 = new Alumno();
            a5 = new Alumno();

            client = new HttpClient();


        }

        async void metodoCrear(object sender, EventArgs e)
        {

            try
            {
                String nombreInterfaz = NombreEntry.Text;
                Console.WriteLine("Nombre Alumno Interfaz: " + nombreInterfaz);

                String matriculaInterfaz = MatriculaEntry.Text;
                Console.WriteLine("Matrícula Alumno Interfaz: " + matriculaInterfaz);

                String domicilioInterfaz = DomicilioEntry.Text;
                Console.WriteLine("Domicilio Alumno Interfaz: " + domicilioInterfaz);

                String nivelClaseInterfaz = NivelClaseEntry.Text;

                selectedIndexCarrera = pickerCarrera.SelectedIndex;
                selectedIndexAlumno = pickerAlumnoConsulta.SelectedIndex;
                Console.WriteLine("Indice seleccionado de Carrera Picker: " + selectedIndexCarrera);

                //Se agrega la materia de prueba al Array de Materias Alumno
                

                m1 = new MateriaUCQ();
                m2 = new MateriaUCQ();
                m3 = new MateriaUCQ();

                m1.IdMateria = "M1";
                m1.NombreMateria = "Materia 1";
                m1.Calificacion = "10";
                m1.NivelClase = "1";
                m1.ProgramaEducativo = "ing";
                m1.Profesor = "profe 1";

                m2.IdMateria = "M2";
                m2.NombreMateria = "Materia 2";
                m2.Calificacion = "10";
                m2.NivelClase = "2";
                m2.ProgramaEducativo = "ing";
                m2.Profesor = "profe 2";

                m3.IdMateria = "M3";
                m3.NombreMateria = "Materia 3";
                m3.Calificacion = "10";
                m3.NivelClase = "3";
                m3.ProgramaEducativo = "ing";
                m3.Profesor = "profe 3";

                switch (selectedIndexAlumno)
                {
                    case 0:
                        a1.Matricula = matriculaInterfaz;
                        a1.Nombre = nombreInterfaz;
                        a1.Universidad = "UCQ";

                        a1.Carrera = selectedIndexCarrera;
                        a1.Domicilio = domicilioInterfaz;

                        a1.NivelClase = nivelClaseInterfaz;

                        a1.Materias = new ArrayList();

                        a1.Materias.Add(m1);
                        a1.Materias.Add(m2);
                        a1.Materias.Add(m3);


                        break;
                    case 1:
                        a2.Matricula = matriculaInterfaz;
                        a2.Nombre = nombreInterfaz;
                        a2.Universidad = "UCQ";

                        a2.Carrera = selectedIndexCarrera;
                        a2.Domicilio = domicilioInterfaz;

                        a2.NivelClase = nivelClaseInterfaz;

                        a2.Materias = new ArrayList();

                        a2.Materias.Add(m1);
                        a2.Materias.Add(m2);
                        a2.Materias.Add(m3);


                        break;
                    case 2:
                        a3.Matricula = matriculaInterfaz;
                        a3.Nombre = nombreInterfaz;
                        a3.Universidad = "UCQ";

                        a3.Carrera = selectedIndexCarrera;
                        a3.Domicilio = domicilioInterfaz;

                        a3.NivelClase = nivelClaseInterfaz;

                        a3.Materias = new ArrayList();

                        a3.Materias.Add(m1);
                        a3.Materias.Add(m2);
                        a3.Materias.Add(m3);


                        break;
                    case 3:
                        a4.Matricula = matriculaInterfaz;
                        a4.Nombre = nombreInterfaz;
                        a4.Universidad = "UCQ";

                        a4.Carrera = selectedIndexCarrera;
                        a4.Domicilio = domicilioInterfaz;

                        a4.NivelClase = nivelClaseInterfaz;

                        a4.Materias = new ArrayList();

                        a4.Materias.Add(m1);
                        a4.Materias.Add(m2);
                        a4.Materias.Add(m3);


                        break;
                    case 4:
                        a5.Matricula = matriculaInterfaz;
                        a5.Nombre = nombreInterfaz;
                        a5.Universidad = "UCQ";

                        a5.Carrera = selectedIndexCarrera;
                        a5.Domicilio = domicilioInterfaz;

                        a5.NivelClase = nivelClaseInterfaz;

                        a5.Materias = new ArrayList();

                        a5.Materias.Add(m1);
                        a5.Materias.Add(m2);
                        a5.Materias.Add(m3);


                        break;
                    default:
                        await DisplayAlert("Alerta","No eligio ningun alumno","Ok");
                        break;


                }

                try
                {
                    Uri uri = new Uri(string.Format("https://ucqwebcuatro.azurewebsites.net/apiUCQAlumno", string.Empty));

                    var formcontent = new FormUrlEncodedContent(new[]
                    {
                    new KeyValuePair<string, string>("nombre",nombreInterfaz),
                    new KeyValuePair<string, string>("domicilio",domicilioInterfaz),
                    new KeyValuePair<string, string>("Matricula",matriculaInterfaz),
                    new KeyValuePair<string, string>("Nivel de clase", nivelClaseInterfaz),
                    new KeyValuePair<string, string>("carrera",""+selectedIndexCarrera)
                    });

                    HttpResponseMessage response = null;

                    response = await client.PostAsync(uri, formcontent);

                    Debug.WriteLine("Respuesta de content en update API: " + response);

                    string content2 = await response.Content.ReadAsStringAsync();

                    Debug.WriteLine("Respuesta de content en update Api Update : " + content2);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error : "+ex.ToString());
                }

                

                //Para mostrar en la consola de salida cada uno de los valores
                //De los atributos del objeto: alumno


            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Parametro: " + ex);
            }

        }

        async void metodoConsultar(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("Comprobación de entrada al método");

                selectedIndexAlumno = pickerAlumnoConsulta.SelectedIndex;
                selectedIndexCarrera = pickerCarrera.SelectedIndex;

                string nombre = "";
                string domicilio = "";
                string matricula = "";
                string nivelClase = "";
                int carrera = -1;

                switch (selectedIndexAlumno)
                {
                    case 0:

                        nombre = a1.Nombre;
                        domicilio = a1.Domicilio;
                        matricula = a1.Matricula;
                        nivelClase = a1.NivelClase;
                        carrera = a1.Carrera;
                        break;

                    case 1:
                        nombre = a2.Nombre;
                        domicilio = a2.Domicilio;
                        matricula = a2.Matricula;
                        nivelClase = a2.NivelClase;
                        carrera = a2.Carrera;
                        break;

                    case 2:
                        nombre = a3.Nombre;
                        domicilio = a3.Domicilio;
                        matricula = a3.Matricula;
                        nivelClase = a3.NivelClase;
                        carrera = a3.Carrera;
                        break;

                    case 3:
                        nombre = a4.Nombre;
                        domicilio = a4.Domicilio;
                        matricula = a4.Matricula;
                        nivelClase = a4.NivelClase;
                        carrera = a4.Carrera;
                        break;

                    case 4:
                        nombre = a5.Nombre;
                        domicilio = a5.Domicilio;
                        matricula = a5.Matricula;
                        nivelClase = a5.NivelClase;
                        carrera = a5.Carrera;
                        break;

                    default:
                        await DisplayAlert("Alerta", "No eligio ningun alumno", "Ok");
                        break;
                }

                NombreEntry.Text = nombre;
                DomicilioEntry.Text = domicilio;
                MatriculaEntry.Text = matricula;
                NivelClaseEntry.Text = nivelClase;
                pickerCarrera.SelectedIndex = carrera;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception en metodo consultar Alumno");
            }
        }

        async void metodoArrayAlumno(object sender, EventArgs args)
        {
            try
            {
                
                Console.WriteLine(" Tamaño del Array de Alumnos : " + AlumnosUCQArray.Count);

                Debug.WriteLine("Tamaño del Array de Alumnos :" + AlumnosUCQArray.Count);

                Console.WriteLine("PRIMER CONTEO : " + AlumnosUCQArray.Count);

                Debug.WriteLine("PRIMER CONTEO DEBUG :" + AlumnosUCQArray.Count);
            }catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }

        


        async void ClaseMateria(object sender, EventArgs args) { await Navigation.PushAsync(new ClaseMateria()); }

    }
}