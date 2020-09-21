using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        private async void onClick(object sender, EventArgs e)
        {
            var result = await DisplayActionSheet("Opciones", "Ok", null, new[] { "Colombia", "México", "Perú" });
            await DisplayAlert("País", $"Escogiste {result}", "Aceptar");
        }
    }
}