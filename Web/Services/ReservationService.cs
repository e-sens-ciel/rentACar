using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using Web.Interfaces;
using Web.Models;

namespace Web.Services
{
    public class ReservationService : IReservationService
    {
        private readonly HttpClient _httpClient;


        public ReservationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> CreateReservationObj(Reservation reservation)
        {
            var content = JsonConvert.SerializeObject(reservation);
            var httpResponse = await _httpClient.PostAsync("https://localhost:7090/Reservation/CreateReservation", new StringContent(content, Encoding.Default, "application/json"));
            if (!httpResponse.IsSuccessStatusCode)
                throw new Exception("Cannot add a new reservation");

            //var createdReservation = JsonConvert.DeserializeObject<Reservation>(await httpResponse.Content.ReadAsStringAsync());
            return httpResponse;
        }
        public async Task<Reservation> GetReservation(int id)
        {


            var httpResponse = await _httpClient.GetAsync("https://localhost:7090/Reservation/" + id);
            var jSon = await httpResponse.Content.ReadAsStringAsync();
            var reservation = JsonConvert.DeserializeObject<Reservation>(jSon);
            return reservation;

        }
        public async Task<List<Reservation>> GetAllReservations()
        {


            var httpResponse = await _httpClient.GetAsync("https://localhost:7090/Reservation/GetAllReservations");
            var jSon = await httpResponse.Content.ReadAsStringAsync();
            var reservations = JsonConvert.DeserializeObject<List<Reservation>>(jSon);
            return reservations;

        }
        
        public async Task<HttpResponseMessage> EditReservation(Reservation reservation)
        {

            var objAsJson = JsonConvert.SerializeObject(reservation);
            var content = new StringContent(objAsJson, Encoding.UTF8, "application/json");
            var result = await _httpClient.PutAsync("https://localhost:7090/Reservation/" + reservation.ReservationID, content);
            return result;

        }
        public async Task<HttpResponseMessage> UpdateReservation(Reservation reservation)
        {
            
            var objAsJson = JsonConvert.SerializeObject(reservation);
            var content = new StringContent(objAsJson, Encoding.UTF8, "application/json");
            var result = await _httpClient.PutAsync("https://localhost:7090/Reservation/UpdateReservation?" + reservation.ReservationID, content);
            return result;

        }

        public async Task<HttpResponseMessage> DeleteReservation(int id)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync("https://localhost:7090/Reservation/DeleteReservation?id=" + id.ToString());

            return response;
        }
    }
}
