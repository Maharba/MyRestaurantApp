using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acr.UserDialogs;
using MyRestaurantApp.Models;
using Xamarin.Forms;

namespace MyRestaurantApp.Views
{
    public partial class PlatillosPage : ContentPage
    {
        public PlatillosPage(string categoria)
        {
            InitializeComponent();

            List<Platillo> platillos = new List<Platillo>()
            {
                new Platillo()
                {
                    Nombre = "Panini Bacon", Descripcion = "Un delicioso panini con tocino, acelgas y muchas cosas wuuuuu", Imagen = "a14.jpg", Precio = 99
                },
                new Platillo()
                {
                    Nombre = "Panini Atún", Descripcion = "Un delicioso panini con tocino, acelgas y muchas cosas wuuuuu", Imagen = "a4.jpg", Precio = 95
                },
                new Platillo()
                {
                    Nombre = "@Panini", Descripcion = "Un delicioso panini con tocino, acelgas y muchas cosas wuuuuu", Imagen = "a9.jpg", Precio = 93
                },
                new Platillo()
                {
                    Nombre = "Panini Bacon", Descripcion = "Un delicioso panini con tocino, acelgas y muchas cosas wuuuuu", Imagen = "a21.jpg", Precio = 96
                },
                new Platillo()
                {
                    Nombre = "Panini Bacon", Descripcion = "Un delicioso panini con tocino, acelgas y muchas cosas wuuuuu", Imagen = "a10.jpg", Precio = 99
                },
                new Platillo()
                {
                    Nombre = "Panini Bacon", Descripcion = "Un delicioso panini con tocino, acelgas y muchas cosas wuuuuu", Imagen = "a2.jpg", Precio = 99
                },
                new Platillo()
                {
                    Nombre = "Panini Bacon", Descripcion = "Un delicioso panini con tocino, acelgas y muchas cosas wuuuuu", Imagen = "a3.jpg", Precio = 99
                },
                new Platillo()
                {
                    Nombre = "Panini Bacon", Descripcion = "Un delicioso panini con tocino, acelgas y muchas cosas wuuuuu", Imagen = "a5.jpg", Precio = 99
                },
                new Platillo()
                {
                    Nombre = "Panini Bacon", Descripcion = "Un delicioso panini con tocino, acelgas y muchas cosas wuuuuu", Imagen = "a20.jpg", Precio = 99
                }
            };

            lstPlatillos.ItemsSource = platillos;

            lstPlatillos.ItemSelected += (sender, args) =>
            {
                ((ListView) sender).SelectedItem = null;
            };

            lstPlatillos.ItemTapped += LstPlatillosOnItemTapped;
        }

        private void LstPlatillosOnItemTapped(object sender, ItemTappedEventArgs itemTappedEventArgs)
        {
            UserDialogs.Instance.ShowSuccess("Producto añadido al Carrito");
        }
    }
}
