using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGalery.XamarinForms.Paginas.PaginaDeNavegacao
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Conteudo01 : ContentPage
    {
        private Label lbllabel;
        private List<string> labels { get; set; } = new List<string>();
        private string[] Arraylabels  =new string[10];
        private int cont = 0;
        private bool status = new bool();
        public Conteudo01()
        {
            status = true;
            InitializeComponent();
            CreateListElement();
            lbllabel = new Label();

            Getall();


        }


        public void Getall()
        {
            //foreach (var item in CreateListElement())
            //{
                if (status)
                {
                    status = false;



                    lbllabel.Text = "Pergunta " +  Arraylabels[cont];

                cont = cont + 1;

        

                    //lbllabel.Text = Arraylabels[cont];

                    EStack.Children.Add(lbllabel);

                }



            //}
        }
        public IEnumerable<string> CreateListElement()
        {
            //labels.Add("Text1");
            //labels.Add("Text2");
            //labels.Add("Text3");
            //labels.Add("Text4");
            //labels.Add("Text5");
            //labels.Add("Text6");
            //labels.Add("Text7");
            //labels.Add("Text8");
            //labels.Add("Text9");
            //labels.Add("Text10");
            //labels.Add("Text11");
            //labels.Add("Text12");
            //labels.Add("Text13");
            //labels.Add("Text14");
            //labels.Add("Text15");
            //labels.Add("Text16");
            //labels.Add("Text17");
            //labels.Add("Text18");
            //labels.Add("Text19");
            //labels.Add("Text20");
            //labels.Add("Text21");
            //labels.Add("Text22");
            //labels.Add("Text23");
            //labels.Add("Text24");
            //labels.Add("Text25");
            //labels.Add("Text25");


            Arraylabels[0] = "1";
            Arraylabels[1] = "2";
            Arraylabels[2] = "3";
            Arraylabels[3] = "4";
            Arraylabels[4] = "5";
            Arraylabels[5] = "6";
            Arraylabels[6] = "7";

            return labels;
        }

        private void AbrirPagina02(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Conteudo02());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            status = true;
            if(cont == 0)
            {
                cont = 0;
            }
          
            Getall();

        }
    }
}