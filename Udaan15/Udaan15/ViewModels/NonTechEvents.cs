using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udaan_15.ViewModels;
using Newtonsoft.Json;

namespace Udaan15.ViewModels
{
    public class NonTechEvents
    {
        [JsonProperty("message")]
        public List<Event> NTList { get; set; }
        public NonTechEvents()
        {
            this.NTList = new List<Event>();
        }
    }
}
