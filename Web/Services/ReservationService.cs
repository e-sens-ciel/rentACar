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

        public async Task<List<Reservation>> GetAllReservations()
        {


            var httpResponse = await _httpClient.GetAsync("https://localhost:7090/Reservation/GetAllReservations");
            var jSon = await httpResponse.Content.ReadAsStringAsync();
            var reservations = JsonConvert.DeserializeObject<List<Reservation>>(jSon);
            return reservations;

        }

        public async Task<HttpResponseMessage> UpdateReservation(Reservation reservation)
        {
            //var httpResponse = await _httpClient.PutAsync("https://localhost:7090/Reservation/UpdateReservation?" + reservation);

            //return httpResponse;
            var objAsJson = JsonConvert.SerializeObject(reservation);
            var content = new StringContent(objAsJson, Encoding.UTF8, "application/json");
            var result = await _httpClient.PutAsync("https://localhost:7090/Reservation/UpdateReservation?"+reservation.ReservationID);
            return result;

        }

        public async Task<HttpResponseMessage> DeleteReservation(int id)
        {
            //var deleteTask = await _httpClient.DeleteAsync("https://localhost:7090/Reservation/DeleteReservation?id="+id.ToString()).Result;
            HttpResponseMessage response = await _httpClient.DeleteAsync("https://localhost:7090/Reservation/DeleteReservation?id=" + id.ToString());

            return response;
        }
    }
}
