using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Geolocator;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace Moodify
{
    public partial class MainPage : ContentPage
    {
        // Track whether the user has authenticated.
        bool authenticated = false;

        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (authenticated == true)
            {
                // Hide the Sign-in button.
                this.loginButton.IsVisible = false;
            }
        }

        async void loginButton_Clicked(object sender, EventArgs e)
        {
            if (App.Authenticator != null)
                authenticated = await App.Authenticator.Authenticate();

            if (authenticated == true)
                this.loginButton.IsVisible = false;
        }
    }
}
