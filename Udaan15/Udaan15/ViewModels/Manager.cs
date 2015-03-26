using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Udaan_15.ViewModels
{
    public class Manager
    {
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("number")]
        public string Contact { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
       // public string Year { get; set; }
        //public string Branch { get; set; }
    }
}
