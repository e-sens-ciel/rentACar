using Microsoft.AspNetCore.Mvc;
using Web.Interfaces;


namespace Web.Controllers
{
    public class ReservationController : Controller
    {
        public IReservationService _reservationService;
        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        public async Task<ActionResult> GetAllReservations()
        {
            var reservations = await _reservationService.GetAllReservations();
            return View(reservations);
        }
    }
}
