using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pruebas
{
    public partial class App : Application
    {

        public static CarouselPage Main;

        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();

            MainPage = new NavigationPage(new MainPage());



        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
