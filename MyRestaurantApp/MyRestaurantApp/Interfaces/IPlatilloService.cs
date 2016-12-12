using System.Collections.Generic;
using System.Threading.Tasks;
using MyRestaurantApp.Models;

namespace MyRestaurantApp.Interfaces
{
    public interface IPlatilloService
    {
        Task<IEnumerable<Platillo>> ObtenerPlatillos();
    }
}