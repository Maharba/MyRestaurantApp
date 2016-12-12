using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MyRestaurantApp.Pages;

namespace MyRestaurantApp
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            Detail = new NavigationPage(new CategoriasPage());
        }
    }
}
