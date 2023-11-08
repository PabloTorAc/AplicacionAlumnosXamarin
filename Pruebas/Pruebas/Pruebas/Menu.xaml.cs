using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pruebas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {

        public int contador;

        public Menu()
        {
            InitializeComponent();
        }

        async void AltaAlumno(object sender, EventArgs args)
        {

            await Navigation.PushAsync(new AltaAlumno());

        }

        async void EE(object sender, EventArgs args)
        {
            contador++;

            if ( contador == 15)
            {
                await Navigation.PushAsync(new Hola());
                contador = 0;
            }

        }

        async void PruebaApi(object sender, EventArgs e)
        {

            try
            {
                await Navigation.PushAsync(new RestService());

                Console.WriteLine("Comprobación de entrada al método");

            }catch (Exception ex)
            {

            }

        }
    }
}