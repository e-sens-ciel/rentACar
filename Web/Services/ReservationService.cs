using Newtonsoft.Json;
using System.Net;
using System.Web.Http;
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

        public async Task<HttpResponseMessage> DeleteReservation(int id)
        {
            //var deleteTask = await _httpClient.DeleteAsync("https://localhost:7090/Reservation/DeleteReservation?id="+id.ToString()).Result;
            HttpResponseMessage response = await _httpClient.DeleteAsync("https://localhost:7090/Reservation/DeleteReservation?id=" + id.ToString());

            return response;
        }



    }
}
