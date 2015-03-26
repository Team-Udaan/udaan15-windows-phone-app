using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Udaan_15.ViewModels;

namespace Udaan15.ViewModels
{
    public class DeptEventList
    {
        [JsonProperty("message")]
        public List<Event> DEList { get; set; }
        public DeptEventList()
        {
            this.DEList = new List<Event>();
        }
    }
}
