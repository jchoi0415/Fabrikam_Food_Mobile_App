using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.WindowsAzure.MobileServices;
using Moodify.DataModels;

namespace Moodify
{
    public class AzureManager
    {

        private static AzureManager instance;
        private MobileServiceClient client;
        private IMobileServiceTable<Menu> menuTable;

        private AzureManager()
        {
            this.client = new MobileServiceClient("http://fabrikamfood16.azurewebsites.net/");
            this.menuTable = this.client.GetTable<Menu>();
        }

        public MobileServiceClient AzureClient
        {
            get { return client; }
        }

        public static AzureManager AzureManagerInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AzureManager();
                }

                return instance;
            }
        }

        public async Task AddOrder(Menu menu)
        {
            await this.menuTable.InsertAsync(menu);
        }

        public async Task<List<Menu>> GetOrder()
        {
            return await this.menuTable.ToListAsync();
        }

        public async Task DeleteOrder(Menu menu)
        {
            await this.menuTable.DeleteAsync(menu);
        }

        public async Task UpdateOrder(Menu menu)
        {
            await this.menuTable.UpdateAsync(menu);
        }
    }
}
