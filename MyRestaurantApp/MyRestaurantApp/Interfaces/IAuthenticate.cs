using System.Threading.Tasks;

namespace MyRestaurantApp.Interfaces
{
    public interface IAuthenticate
    {
        Task<string> Authenticate();
    }
}