using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Pruebas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void MetodoIngresar(object sender, EventArgs args)
        {
            try
            {

                await Navigation.PushAsync(new Menu());

                Console.WriteLine(" COMPROBACIÓN DE ENTRADA A EL MÉTODO INGRESAR ");

                if ((user.Text.Equals("usuarioPrueba"))&&(pass.Text.Equals("12345")))
                {
                    await Navigation.PushAsync(new Menu());
                }
                else
                {
                    Console.WriteLine(" USUARIO O CONTRASEÑA INCORRECTOS ");

                    await DisplayAlert("Avisoooo", "Se requiere de datos correctos", "OK");
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("Exepción Parametro: " + e);

            }
        }

    }
}
