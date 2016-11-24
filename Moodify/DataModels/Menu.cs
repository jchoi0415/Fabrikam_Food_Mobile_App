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
        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }

        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

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

        [JsonProperty(PropertyName = "updatedAt")]
        public string updatedAt { get; set; }

        [JsonProperty(PropertyName = "version")]
        public string version { get; set; }

        [JsonProperty(PropertyName = "deleted")]
        public bool deleted { get; set; }
    }
}
