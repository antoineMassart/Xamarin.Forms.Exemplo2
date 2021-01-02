using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exemplo2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NumbersPage : ContentPage
    {

        public class NumbersList { public int Number { get; set; } }

        public NumbersPage()
        {
            InitializeComponent();

            
            var ListNumbers = new List<NumbersList>();
            
            for (int i = 0; i < 1000; i++)
            {
                ListNumbers.Add(new NumbersList { Number = i + 1 });
            }
            
            listOfNumbers.ItemsSource = ListNumbers;


        }
    }
}