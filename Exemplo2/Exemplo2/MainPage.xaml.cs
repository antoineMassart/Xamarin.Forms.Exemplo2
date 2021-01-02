using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exemplo2
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }


        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NumbersPage());


        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WordsPage());

        }


        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContentsPage());
     
        }

    }
}
