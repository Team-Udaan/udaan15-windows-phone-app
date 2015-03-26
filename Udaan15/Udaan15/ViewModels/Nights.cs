using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Udaan_15.ViewModels
{
    public class Nights
    {
        [JsonProperty("name")]
        public string name { get; set; }
        //public DateTime dateTime { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        //public string[] Notice { get; set; }
    }
}
