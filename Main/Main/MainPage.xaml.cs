using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Main
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void espresso_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EspressoList());
        }

        private async void hotDrinks_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new hotDrinksList());
        }

        private async void coldDrinks_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new coldDrinksList());
        }

        private async void quickBites_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new quickBitesList());
        }
    }
}
