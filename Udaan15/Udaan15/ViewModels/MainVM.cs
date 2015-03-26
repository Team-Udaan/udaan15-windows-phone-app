using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using Udaan_15.ViewModels;

namespace Udaan15.ViewModels
{
    public class MainVM
    {
        public DeptList Departments { get; set; }
        public DeptEventList Devents { get; set; }
        public List<Event> listToDisplay { get; set; }
        public NonTechEvents Ntevents { get; set; }
        public Cultural CulturalList { get; set; }

        public bool DeptLoaded { get; set; }
        public bool DELoaded { get; set; }
        public bool NteventsLoaded { get; set; }
        public bool CulturalLoaded { get; set; }
        public MainVM()
        {
            this.Departments=new DeptList();
            this.Devents = new DeptEventList();
            this.Ntevents = new NonTechEvents();
            this.CulturalList = new Cultural();
            this.listToDisplay = new List<Event>();
        }
        public void LoadDeptEvents()
        {
            makeRequest("/api/tech/all");
        }
        public void LoadDept()
        {
            makeRequest("/api/tech/departments");
        }
        public void LoadNT()
        {
            makeRequest("/api/nontech/all");
        }
        public void LoadCultural()
        {
            makeRequest("/api/cultural");
            //this.CulturalList.CulturalEvents = new List<Nights>();
            //this.CulturalList.CulturalEvents.Add(new Nights() { name = "Coming Soon...", Description = "coming soon..." });
            //this.CulturalLoaded = true;
        }
        public async void makeRequest(string path)
        {
            await useHttpClient(path);
        }
        public async Task MakeRequest(string path)
        {
            await useHttpClient(path);
        }
        //http://54.68.178.15:8000
        private async Task useHttpClient(string path)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, new Uri("http://54.68.253.83:8000" + path));
            var response = await client.SendAsync(request);
            string ResponseString = response.Content.ReadAsStringAsync().Result.ToString();
           // MessageBox.Show(ResponseString);
            if (response.IsSuccessStatusCode)
            {
                JsonParser j = new JsonParser();
                if (path.Contains("nontech"))
                {
                    this.Ntevents = j.getNTEvents(ResponseString);
                    this.NteventsLoaded = true;
                }
                else if(path.Contains("cultural"))
                {
                    this.CulturalList = j.getNights(ResponseString);
                    this.CulturalLoaded = true;
                }
                else if (path == "/api/tech/departments")
                {
                    this.Departments = j.getDepartments(ResponseString);
                    this.DeptLoaded = true;
                    //return;
                }
                else if (path.Contains("/api/tech/all"))
                {
                    this.Devents = j.getTEvents(ResponseString);
                    this.DELoaded = true;
                }
            }
        }
    }
}
