using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Udaan15.ViewModels;
using Newtonsoft.Json;

namespace Udaan_15.ViewModels
{
    public class Cultural
    {
        [JsonProperty("message")]
        public List<Nights> CulturalEvents { get; set; }

        public Cultural()
        {
            CulturalEvents = new List<Nights>();
        }

        //private void LoadCulturalData()
        //{
        //    makeRequest("/api/test");
        //}
        //public async void makeRequest(string path)
        //{
        //    await useHttpClient(path);
        //}

        // private async Task useHttpClient(string path)
        // {
        //     var client = new HttpClient();
        //     var request = new HttpRequestMessage(HttpMethod.Get, new Uri("http://54.68.178.15:8000" + path));
        //     var response = await client.SendAsync(request);
        //     string ResponseString = response.Content.ReadAsStringAsync().Result.ToString();
        //     if (response.IsSuccessStatusCode)
        //     {
        //         JsonParser j = new JsonParser();
        //         this.CulturalEvents = j.getNights(ResponseString);
        //         this.Loaded = true;
        //     }
        // }
    }
}
