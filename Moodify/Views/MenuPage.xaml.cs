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
        public bool Started { get; private set; }

        public MenuPage()
        {
            InitializeComponent();
            Started = true;
        }
        
        async void Steak_Clicked(Object sender, EventArgs e)
        {
            if (Started)
            {
                Menu order = new Menu()
                {
                    Name = "Order",
                    Steak = 0,
                    Pasta = 0,
                    Pizza = 0,
                    BeefBurger = 0,
                    Cocktail = 0,
                    IceCream = 0,
                    Coffee = 0,
                    Wine = 0
                };
                await AzureManager.AzureManagerInstance.AddOrder(order);
                Started = false;
            }

            List<Menu> menus = await AzureManager.AzureManagerInstance.GetOrder();
            foreach (Menu menu in menus)
            {
                if (menu.Name == "Order")
                {
                    menu.Steak = menu.Steak + 1;
                    await AzureManager.AzureManagerInstance.UpdateOrder(menu);
                }
            }
            await DisplayAlert("You ordered a Steak!","Thank you!", "Yea");
        }

        async void Pasta_Clicked(Object sender, EventArgs e)
        {
            if (Started)
            {
                Menu order = new Menu()
                {
                    Name = "Order",
                    Steak = 0,
                    Pasta = 0,
                    Pizza = 0,
                    BeefBurger = 0,
                    Cocktail = 0,
                    IceCream = 0,
                    Coffee = 0,
                    Wine = 0
                };
                await AzureManager.AzureManagerInstance.AddOrder(order);
                Started = false;
            }

            List<Menu> menus = await AzureManager.AzureManagerInstance.GetOrder();
            foreach (Menu menu in menus)
            {
                if (menu.Name == "Order")
                {
                    menu.Pasta = menu.Pasta + 1;
                    await AzureManager.AzureManagerInstance.UpdateOrder(menu);
                }
            }
            await DisplayAlert("You ordered a Pasta!", "Thank you!", "Yea");
        }

        async void Pizza_Clicked(Object sender, EventArgs e)
        {
            if (Started)
            {
                Menu order = new Menu()
                {
                    Name = "Order",
                    Steak = 0,
                    Pasta = 0,
                    Pizza = 0,
                    BeefBurger = 0,
                    Cocktail = 0,
                    IceCream = 0,
                    Coffee = 0,
                    Wine = 0
                };
                await AzureManager.AzureManagerInstance.AddOrder(order);
                Started = false;
            }

            List<Menu> menus = await AzureManager.AzureManagerInstance.GetOrder();
            foreach (Menu menu in menus)
            {
                if (menu.Name == "Order")
                {
                    menu.Pizza = menu.Pizza + 1;
                    await AzureManager.AzureManagerInstance.UpdateOrder(menu);
                }
            }
            await DisplayAlert("You ordered a Pizza!", "Thank you!", "Yea");
        }

        async void Burger_Clicked(Object sender, EventArgs e)
        {
            if (Started)
            {
                Menu order = new Menu()
                {
                    Name = "Order",
                    Steak = 0,
                    Pasta = 0,
                    Pizza = 0,
                    BeefBurger = 0,
                    Cocktail = 0,
                    IceCream = 0,
                    Coffee = 0,
                    Wine = 0
                };
                await AzureManager.AzureManagerInstance.AddOrder(order);
                Started = false;
            }

            List<Menu> menus = await AzureManager.AzureManagerInstance.GetOrder();
            foreach (Menu menu in menus)
            {
                if (menu.Name == "Order")
                {
                    menu.BeefBurger = menu.BeefBurger + 1;
                    await AzureManager.AzureManagerInstance.UpdateOrder(menu);
                }
            }
            await DisplayAlert("You ordered a Burger!", "Thank you!", "Yea");
        }

        async void Cocktail_Clicked(Object sender, EventArgs e)
        {
            if (Started)
            {
                Menu order = new Menu()
                {
                    Name = "Order",
                    Steak = 0,
                    Pasta = 0,
                    Pizza = 0,
                    BeefBurger = 0,
                    Cocktail = 0,
                    IceCream = 0,
                    Coffee = 0,
                    Wine = 0
                };
                await AzureManager.AzureManagerInstance.AddOrder(order);
                Started = false;
            }

            List<Menu> menus = await AzureManager.AzureManagerInstance.GetOrder();
            foreach (Menu menu in menus)
            {
                if (menu.Name == "Order")
                {
                    menu.Cocktail = menu.Cocktail + 1;
                    await AzureManager.AzureManagerInstance.UpdateOrder(menu);
                }
            }
            await DisplayAlert("You ordered a Cocktail!", "Thank you!", "Yea");
        }

        async void IceCream_Clicked(Object sender, EventArgs e)
        {
            if (Started)
            {
                Menu order = new Menu()
                {
                    Name = "Order",
                    Steak = 0,
                    Pasta = 0,
                    Pizza = 0,
                    BeefBurger = 0,
                    Cocktail = 0,
                    IceCream = 0,
                    Coffee = 0,
                    Wine = 0
                };
                await AzureManager.AzureManagerInstance.AddOrder(order);
                Started = false;
            }

            List<Menu> menus = await AzureManager.AzureManagerInstance.GetOrder();
            foreach (Menu menu in menus)
            {
                if (menu.Name == "Order")
                {
                    menu.IceCream = menu.IceCream + 1;
                    await AzureManager.AzureManagerInstance.UpdateOrder(menu);
                }
            }
            await DisplayAlert("You ordered a Ice Cream!", "Thank you!", "Yea");
        }

        async void Coffee_Clicked(Object sender, EventArgs e)
        {
            if (Started)
            {
                Menu order = new Menu()
                {
                    Name = "Order",
                    Steak = 0,
                    Pasta = 0,
                    Pizza = 0,
                    BeefBurger = 0,
                    Cocktail = 0,
                    IceCream = 0,
                    Coffee = 0,
                    Wine = 0
                };
                await AzureManager.AzureManagerInstance.AddOrder(order);
                Started = false;
            }

            List<Menu> menus = await AzureManager.AzureManagerInstance.GetOrder();
            foreach (Menu menu in menus)
            {
                if (menu.Name == "Order")
                {
                    menu.Coffee = menu.Coffee + 1;
                    await AzureManager.AzureManagerInstance.UpdateOrder(menu);
                }
            }
            await DisplayAlert("You ordered a cup of Coffee!", "Thank you!", "Yea");
        }

        async void Wine_Clicked(Object sender, EventArgs e)
        {
            if (Started)
            {
                Menu order = new Menu()
                {
                    Name = "Order",
                    Steak = 0,
                    Pasta = 0,
                    Pizza = 0,
                    BeefBurger = 0,
                    Cocktail = 0,
                    IceCream = 0,
                    Coffee = 0,
                    Wine = 0
                };
                await AzureManager.AzureManagerInstance.AddOrder(order);
                Started = false;
            }

            List<Menu> menus = await AzureManager.AzureManagerInstance.GetOrder();
            foreach (Menu menu in menus)
            {
                if (menu.Name == "Order")
                {
                    menu.Wine = menu.Wine + 1;
                    await AzureManager.AzureManagerInstance.UpdateOrder(menu);
                }
            }
            await DisplayAlert("You ordered a glass of Wine!", "Thank you!", "Yea");
        }

        async void ViewOrder_Clicked(Object sender, EventArgs e)
        {
            if (Started)
            {
                Menu order = new Menu()
                {
                    Name = "Order",
                    Steak = 0,
                    Pasta = 0,
                    Pizza = 0,
                    BeefBurger = 0,
                    Cocktail = 0,
                    IceCream = 0,
                    Coffee = 0,
                    Wine = 0
                };
                await AzureManager.AzureManagerInstance.AddOrder(order);
                Started = false;
            }
            List<Menu> menus = await AzureManager.AzureManagerInstance.GetOrder();
            foreach (Menu menu in menus)
            {
                if (menu.Name == "Order")
                {
                    this.SteakNum.Text = "" + menu.Steak;
                    this.PastaNum.Text = "" + menu.Pasta;
                    this.PizzaNum.Text = "" + menu.Pizza;
                    this.BurgerNum.Text = "" + menu.BeefBurger;
                    this.CocktailNum.Text = "" + menu.Cocktail;
                    this.CreamNum.Text = "" + menu.IceCream;
                    this.CoffeeNum.Text = "" + menu.Coffee;
                    this.WineNum.Text = "" + menu.Wine;
                }
            }
        }

        async void ResetOrder_Clicked(Object sender, EventArgs e)
        {
            List<Menu> menus = await AzureManager.AzureManagerInstance.GetOrder();
            foreach (Menu menu in menus)
            {
                if (menu.Name == "Order")
                {
                    await AzureManager.AzureManagerInstance.DeleteOrder(menu);
                }
            }
            this.SteakNum.Text = "0";
            this.PastaNum.Text = "0";
            this.PizzaNum.Text = "0";
            this.BurgerNum.Text = "0";
            this.CocktailNum.Text = "0";
            this.CreamNum.Text = "0";
            this.CoffeeNum.Text = "0";
            this.WineNum.Text = "0";
            Started = true;
        }
    }
}
