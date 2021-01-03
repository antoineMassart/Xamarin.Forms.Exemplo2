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


        public class ClassListContent
        {
            public ImageSource Image { get; set; }
            public string Text { get; set; }
            public int Num { get; set; }
        }
        


        public ContentsPage()
        {
            InitializeComponent();

            var ListContent = new List<ClassListContent>();


            ListContent.Add(new ClassListContent {Image = ImageSource.FromResource("Exemplo2.Images.pinnaple.png"),Text = "Pinnaple", Num = 1});
            ListContent.Add(new ClassListContent { Image = ImageSource.FromResource("Exemplo2.Images.apple.png"), Text = "Apple", Num = 2 });
            ListContent.Add(new ClassListContent { Image = ImageSource.FromResource("Exemplo2.Images.cherri.png"), Text = "Cherry", Num = 3 });
            ListContent.Add(new ClassListContent { Image = ImageSource.FromResource("Exemplo2.Images.mango.png"), Text = "Mango", Num = 4 });
            ListContent.Add(new ClassListContent { Image = ImageSource.FromResource("Exemplo2.Images.strawberry.png"), Text = "Strawbery", Num = 5 });


            for (int i = 0; i < 10; i++)
            {
                ListContent.Add(new ClassListContent { Image = ImageSource.FromResource("Exemplo2.Images.empty.png"), Text = "empty", Num = 0 });

            }


                listOfContents.ItemsSource = ListContent;
        }
    }
}