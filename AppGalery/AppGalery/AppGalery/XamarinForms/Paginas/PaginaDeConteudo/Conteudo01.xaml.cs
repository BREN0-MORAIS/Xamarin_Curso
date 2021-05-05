using AppGalery.XamarinForms.Paginas.PaginaDeNavegacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGalery.XamarinForms.Paginas.PaginaDeConteudo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Conteudo01 : ContentPage
    {


        public Conteudo01()
        {
            InitializeComponent();
     
        }

        private void AbrirPagina02(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Conteudo02());
        }
    }
}