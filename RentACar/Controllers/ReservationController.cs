
using Microsoft.AspNetCore.Mvc;
using MODELS;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Mvc;

namespace RentACar.Controllers
{
    public class ReservationController : Controller
    {
        private readonly HttpClient _httpClient;
        //public IReservationService _reservationService;
        public ReservationController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //public IActionResult GetAllReservations()
        //{
        //    List<Reservation> reservations = new List<Reservation>();
        //    var response = _httpClient.GetAsync("https://localhost:7090/Reservation/GetAllReservations");

        //    //return View(response);
        //}
    }
}