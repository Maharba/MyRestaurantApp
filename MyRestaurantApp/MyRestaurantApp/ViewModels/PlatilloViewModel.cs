using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using MyRestaurantApp.Interfaces;
using MyRestaurantApp.Models;

namespace MyRestaurantApp.ViewModels
{
    public class PlatilloViewModel
    {
        private readonly IPlatilloService _platillosService;
        public ObservableCollection<Platillo> Platillos { get; set; }

        public PlatilloViewModel(IPlatilloService plattiService)
        {
            if (plattiService == null) throw new ArgumentNullException("peopleService");
            _platillosService = plattiService;
        }

        public async Task Init()
        {
            if (Platillos != null) return;
            Platillos = new ObservableCollection<Platillo>(await _platillosService.ObtenerPlatillos());
        }
    }
}