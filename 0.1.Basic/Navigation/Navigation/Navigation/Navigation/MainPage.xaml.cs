using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Navigation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            MessagingCenter.Subscribe<Page2>(this, "Hola", async (s) =>
            {
                await DisplayAlert("Saludo", "Hola", "Ok");
            });
        }

        private async void onClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
    }
}
