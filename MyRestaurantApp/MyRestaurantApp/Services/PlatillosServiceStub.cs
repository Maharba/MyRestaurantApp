using System.Collections.Generic;
using System.Threading.Tasks;
using MyRestaurantApp.Models;

namespace MyRestaurantApp.Services
{
    public class PlatillosServiceStub
    {
        public Task<IEnumerable<Platillo>> ObtenerPlatillos()
        {
            return Task.Run(() => GenerarPlatillos());
        }

        private IEnumerable<Platillo> GenerarPlatillos()
        {
            var platillos = new List<Platillo>();
            platillos.Add(new Platillo()
            {
                Nombre = "Quesabrosas Bacon",
                Descripcion = "Un bombazo de sabor",
                Imagen = "a4.png",
                Categoria = "Quesabrosas",
                Precio = 99
            });
            return platillos;
        }
    }
}