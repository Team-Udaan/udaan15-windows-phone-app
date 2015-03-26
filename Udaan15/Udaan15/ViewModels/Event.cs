using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows;

namespace Udaan_15.ViewModels
{
    public class Event
    {
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("description")]
        public string desc { get; set; }
        public string Description { get; set; }
        [JsonProperty("numberOfParticipants")]
        public string NoOfParticipants { get; set; }
        [JsonProperty("prize")]
        public string prize { get; set; }
        [JsonProperty("department")]
        public string Dept { get; set; }
        //public DateTime dateTime { get; set; }
        //public string Venue { get; set; }
        //public string[] notice { get; set; }
        [JsonProperty("manager")]
        public List<Manager> Managers { get; set; }
        [JsonProperty("fees")]
        public string Fee { get; set; }
        //public int jury { get; set; }

        public Event()
        {
            this.Description = "Tap to see details";
        }
    }
}
