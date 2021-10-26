using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Main
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage()
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