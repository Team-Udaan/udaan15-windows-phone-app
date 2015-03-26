using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Udaan_15.ViewModels
{
    public class Department
    {
        [JsonProperty("alias")]
        public string name { get; set; }
        [JsonProperty("name")]
        public string Description { get; set; }
        //public List<Event> EventList { get; set; }
    }
}
