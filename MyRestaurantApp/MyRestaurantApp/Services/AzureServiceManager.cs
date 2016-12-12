using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using Microsoft.WindowsAzure.MobileServices.Sync;
using MyRestaurantApp.Models;

namespace MyRestaurantApp.Services
{
    public class AzureServiceManager
    {
        public MobileServiceClient ServiceClient { get; set; }

        private IMobileServiceSyncTable<Platillo> _platillosSyncTable;

        private bool _inicializado;

        private async Task Initilize()
        {
            if (_inicializado) return;

            ServiceClient = new MobileServiceClient(Keys.AZURE_URL);

            const string archivo = "restaurante.db3";
            var store = new MobileServiceSQLiteStore(archivo);
            store.DefineTable<Platillo>();

            await ServiceClient.SyncContext.InitializeAsync(store, StoreTrackingOptions.AllNotifications);

            _platillosSyncTable = ServiceClient.GetSyncTable<Platillo>();
            _inicializado = true;
        }

        private async Task SyncPlatillos()
        {
            await _platillosSyncTable.PullAsync("todos_platillos", _platillosSyncTable.CreateQuery());
            await ServiceClient.SyncContext.PushAsync();
        }

        public async Task<IEnumerable<Platillo>> ObtenerPlatillos()
        {
            await Initilize();
            await SyncPlatillos();
            return await _platillosSyncTable.OrderBy(p => p.Categoria).ToEnumerableAsync();
        }
    }
}