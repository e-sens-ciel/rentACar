using Newtonsoft.Json;
using System.Net;
using System.Text;
using Web.Interfaces;
using Web.Models;

namespace Web.Services
{
    public class VoitureService : IVoitureService
    {
        private readonly HttpClient _httpClient;


        public VoitureService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Voiture>> GetAllVoitures()
        {
            var httpResponse = await _httpClient.GetAsync("https://localhost:7090/Voiture/GetAllVoitures");
            var jSon = await httpResponse.Content.ReadAsStringAsync();
            var voitures = JsonConvert.DeserializeObject<List<Voiture>>(jSon);
            return voitures;
        }

        public async Task<Voiture> GetVoiture(int id)
        {
            var httpResponse = await _httpClient.GetAsync("https://localhost:7090/Voiture/" + id);
            var jSon = await httpResponse.Content.ReadAsStringAsync();
            var voiture = JsonConvert.DeserializeObject<Voiture>(jSon);
            return voiture;
        }

        public async Task<HttpResponseMessage> EditVoiture(Voiture voiture)
        {

            var objAsJson = JsonConvert.SerializeObject(voiture);
            var content = new StringContent(objAsJson, Encoding.UTF8, "application/json");
            var result = await _httpClient.PutAsync("https://localhost:7090/Voiture/" + voiture.VoitureID, content);
            return result;

        }

        public async Task<HttpResponseMessage> UpdateVoiture(Voiture voiture)
        {

            var objAsJson = JsonConvert.SerializeObject(voiture);
            var content = new StringContent(objAsJson, Encoding.UTF8, "application/json");
            var result = await _httpClient.PutAsync("https://localhost:7090/Voiture/UpdateVoiture?" + voiture.VoitureID, content);
            return result;

        }

        public async Task<HttpResponseMessage> DeleteVoiture(int id)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync("https://localhost:7090/Voiture/DeleteVoiture?id=" + id.ToString());

            return response;
        }

        public async Task<HttpResponseMessage> CreateVoitureObj(Voiture voiture)
        {
            var content = JsonConvert.SerializeObject(voiture);
            var httpResponse = await _httpClient.PostAsync("https://localhost:7090/Voiture/CreateVoiture", new StringContent(content, Encoding.Default, "application/json"));
            if (!httpResponse.IsSuccessStatusCode)
                throw new Exception("Cannot add a new voiture");

            //var createdReservation = JsonConvert.DeserializeObject<Reservation>(await httpResponse.Content.ReadAsStringAsync());
            return httpResponse;
        }


    }
}
