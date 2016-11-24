using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Moodify.DataModels;
using Xamarin.Forms;

namespace Moodify
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        public async void ViewOrder_Clicked(Object sender, EventArgs e)
        {
            List<Menu> menus = await AzureManager.AzureManagerInstance.GetOrder();
            orderList.ItemsSource = menus;
        }
    }
}
