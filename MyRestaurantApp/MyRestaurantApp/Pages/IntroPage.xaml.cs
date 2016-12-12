using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRestaurantApp.Views.Elements;
using Xamarin.Forms;

namespace MyRestaurantApp.Pages
{
    public partial class IntroPage : ContentPage
    {
        public IntroPage()
        {
            InitializeComponent();

            btnLoginFacebook.Clicked += BtnLoginFacebookOnClicked;

            crsIntro.ItemsSource = new List<IntroElement>()
            {
                new IntroElement() { Image = "sandwich.png", Text = "Inicia tu día", Detail = "Comiendo sano, delicioso y nutritivo"},
                new IntroElement() { Image = "chef.png", Text = "Nuevas Especialidades", Detail = "Prueba nuevos sabores que solo los encuentras aquí" },
                new IntroElement() { Image = "salad.png", Text = "¿Amas comer y estás a dieta?", Detail = "Mejorar la alimentación no es un sacrificio" },
                new IntroElement() { Image = "cutlery.png", Text = "Nuevo Menú", Detail = "Prueba el nuevo menú" },
            };

            Device.StartTimer(TimeSpan.FromSeconds(5), () =>
            {
                int position = crsIntro.Position + 1;
                if (position < crsIntro.ItemsSource.Count)
                {
                    crsIntro.SetCurrentPage(position);
                }
                else
                {
                    position = 0;
                    crsIntro.SetCurrentPage(position);
                }
                return true;
            });
        }

        private async void BtnLoginFacebookOnClicked(object sender, EventArgs eventArgs)
        {
            /*if (App.Authenticator != null)
            {
                _authenticated = await App.Authenticator.Authenticate();
            }

            await DisplayAlert("Usuario", _authenticated, "OK");*/
            App.Current.MainPage = new MainPage();
        }
    }
}
