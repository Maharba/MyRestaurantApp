using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRestaurantApp.Views;
using Xamarin.Forms;

namespace MyRestaurantApp.Pages
{
    public partial class CategoriasPage : ContentPage
    {
        private TapGestureRecognizer _tap;

        public CategoriasPage()
        {
            InitializeComponent();

            _tap = new TapGestureRecognizer();
            _tap.Tapped += TapOnTapped;

            crcPaninis.GestureRecognizers.Add(_tap);
        }

        private async void TapOnTapped(object sender, EventArgs eventArgs)
        {
            await Navigation.PushAsync(new PlatillosPage("Paninis"));
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();


            grdMain.Opacity = 0;
            await grdMain.FadeTo(1, 500);
        }
    }
}
