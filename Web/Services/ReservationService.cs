using Newtonsoft.Json;
using System.Net;
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
    }
}
