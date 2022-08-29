using Newtonsoft.Json;
using System.Net;
using System.Text;
using Web.Interfaces;
using Web.Models;

namespace Web.Services
{
    public class DepotService : IDepotService
    {
        private readonly HttpClient _httpClient;


        public DepotService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Depot>> GetAllDepots()
        {


            var httpResponse = await _httpClient.GetAsync("https://localhost:7090/Depot/GetAllDepots");
            var jSon = await httpResponse.Content.ReadAsStringAsync();
            var depots = JsonConvert.DeserializeObject<List<Depot>>(jSon);
            return depots;

        }

        public async Task<Depot> GetDepot(int id)
        {
            var httpResponse = await _httpClient.GetAsync("https://localhost:7090/depot/" + id);
            var jSon = await httpResponse.Content.ReadAsStringAsync();
            var depot = JsonConvert.DeserializeObject<Depot>(jSon);
            return depot;
        }

        public async Task<HttpResponseMessage> EditDepot(Depot depot)
        {

            var objAsJson = JsonConvert.SerializeObject(depot);
            var content = new StringContent(objAsJson, Encoding.UTF8, "application/json");
            var result = await _httpClient.PutAsync("https://localhost:7090/depot/" + depot.DepotID, content);
            return result;

        }

        public async Task<HttpResponseMessage> UpdateDepot(Depot depot)
        {

            var objAsJson = JsonConvert.SerializeObject(depot);
            var content = new StringContent(objAsJson, Encoding.UTF8, "application/json");
            var result = await _httpClient.PutAsync("https://localhost:7090/depot/UpdateDepot?" + depot.DepotID, content);
            return result;

        }

        public async Task<HttpResponseMessage> DeleteDepot(int id)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync("https://localhost:7090/depot/DeleteDepot?id=" + id.ToString());

            return response;
        }

        public async Task<HttpResponseMessage> CreateDepotObj(Depot depot)
        {
            var content = JsonConvert.SerializeObject(depot);
            var httpResponse = await _httpClient.PostAsync("https://localhost:7090/depot/CreateDepot", new StringContent(content, Encoding.Default, "application/json"));
            if (!httpResponse.IsSuccessStatusCode)
                throw new Exception("Cannot add a new Depot");

            //var createdReservation = JsonConvert.DeserializeObject<Reservation>(await httpResponse.Content.ReadAsStringAsync());
            return httpResponse;
        }
    }
}