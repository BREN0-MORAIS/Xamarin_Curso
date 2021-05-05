using AppGalery.XamarinForms.Paginas.PaginaCarrosel;
using AppGalery.XamarinForms.Paginas.PaginaDeNavegacao;
using AppGalery.XamarinForms.Paginas.PaginasAbas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGalery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new Conteudo01());

            //MainPage = new XamarinForms.Paginas.Modal.Conteudo01();
            MainPage = new Abas();
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
