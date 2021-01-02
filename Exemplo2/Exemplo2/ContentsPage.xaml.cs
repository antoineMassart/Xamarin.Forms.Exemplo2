using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exemplo2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContentsPage : ContentPage
    {


        public class ClassListaImagemTextoNumero
        {
            public ImageSource Imagem { get; set; }
            public string Texto { get; set; }
            public int Numero { get; set; }
        }

        

        public ContentsPage()
        {
            InitializeComponent();

            var ListaImagemTextoNumero = new List<ClassListaImagemTextoNumero>();
            
        
            ListaImagemTextoNumero.Add(new ClassListaImagemTextoNumero{Imagem = ImageSource.FromResource("Exemplo2.Images.pinnaple.png"),Texto = "Pinnaple", Numero = 1});
            ListaImagemTextoNumero.Add(new ClassListaImagemTextoNumero { Imagem = ImageSource.FromResource("Exemplo2.Images.apple.png"), Texto = "Apple", Numero = 2 });
            ListaImagemTextoNumero.Add(new ClassListaImagemTextoNumero { Imagem = ImageSource.FromResource("Exemplo2.Images.cherri.png"), Texto = "Cherry", Numero = 3 });
            ListaImagemTextoNumero.Add(new ClassListaImagemTextoNumero { Imagem = ImageSource.FromResource("Exemplo2.Images.mango.png"), Texto = "Mango", Numero = 4 });
            ListaImagemTextoNumero.Add(new ClassListaImagemTextoNumero { Imagem = ImageSource.FromResource("Exemplo2.Images.strawberry.png"), Texto = "Strawbery", Numero = 5 });


            for (int i = 0; i < 10; i++)
            {
                ListaImagemTextoNumero.Add(new ClassListaImagemTextoNumero { Imagem = ImageSource.FromResource("Exemplo2.Images.empty.png"), Texto = "empty", Numero = 0 });

            }


                listOfContents.ItemsSource = ListaImagemTextoNumero;
        }
    }
}