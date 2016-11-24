using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodify.DataModels
{
    public class Menu
    {
        [JsonProperty(PropertyName = "Id")]
        public string ID { get; set; }

        [JsonProperty(PropertyName = "Steak")]
        public int Steak { get; set; }

        [JsonProperty(PropertyName = "Pasta")]
        public int Pasta { get; set; }

        [JsonProperty(PropertyName = "Pizza")]
        public int Pizza { get; set; }

        [JsonProperty(PropertyName = "BeefBurger")]
        public int BeefBurger { get; set; }

        [JsonProperty(PropertyName = "Cocktail")]
        public int Cocktail { get; set; }

        [JsonProperty(PropertyName = "IceCream")]
        public int IceCream { get; set; }

        [JsonProperty(PropertyName = "Coffee")]
        public int Coffee { get; set; }

        [JsonProperty(PropertyName = "Wine")]
        public int Wine { get; set; }

        [JsonProperty(PropertyName = "createdAt")]
        public DateTime Date { get; set; }

        [JsonProperty(PropertyName = "lat")]
        public double Lat { get; set; }

        [JsonProperty(PropertyName = "lon")]
        public double Lon { get; set; }
    }
}
