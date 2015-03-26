using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udaan_15.ViewModels;
using Newtonsoft.Json;

namespace Udaan15.ViewModels
{
    public class DeptList
    {
        [JsonProperty("message")]
        public List<Department> ListOfDepartments { get; set; }
        public DeptList()
        {
            this.ListOfDepartments = new List<Department>();
        }
    }
}
