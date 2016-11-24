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
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();
            googleDist();
        }

        async void googleDist()
        {
            HttpClient client = new HttpClient();

            var geo = CrossGeolocator.Current;
            var position = await geo.GetPositionAsync(timeoutMilliseconds: 20000);
            var lat = position.Latitude;
            var lon = position.Longitude;

            string URL = "https://maps.googleapis.com/maps/api/distancematrix/json?units=metric&origins=" + lat + "," + lon + "&destinations=83+Symonds+St+Auckland&key=AIzaSyCGUQXh2klOEVeEnBswdOCet8GtWmoR78A";

            var success = await client.GetAsync(URL);
            if (success.IsSuccessStatusCode)
            {
                var result = await success.Content.ReadAsStringAsync();

                Deserializer.Result results = JsonConvert.DeserializeObject<Deserializer.Result>(result);
                string curr = results.origin_addresses[0];
                string targ = results.destination_addresses[0];
                string dis = results.rows[0].elements[0].distance.text;
                string dur = results.rows[0].elements[0].duration.text;

                this.Sentence1.Text = "Our location: " + targ;
                this.Sentence2.Text = "Your location: " + curr;
                this.Sentence3.Text = "We are located " + dis + " from you!";
                this.Sentence4.Text = "It will only take you " + dur + " by car to get here!";
            }
        }
    }
}
