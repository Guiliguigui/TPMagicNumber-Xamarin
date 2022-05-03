using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP2Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Play : ContentPage
    {
        public int MagicNumber { get; set; }
        public Play()
        {
            var rand = new Random();
            MagicNumber = rand.Next(1,11);
            InitializeComponent();
        }

        private void TestNumber(object sender, EventArgs e)
        {
            int testNumber = int.Parse(numberEntry.Text ?? "0");
            if (MagicNumber != testNumber)
            {
                DisplayAlert(
                      "Attention",
                      $"Le nombre magique est plus {(MagicNumber > testNumber ? "grand" : "petit")}",
                      "OK");
                numberEntry.Text = "";
            }
            else
                Navigation.PushAsync(new Result(MagicNumber));
        }
    }
}