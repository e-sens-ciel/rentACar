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

        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<ActionResult> GetAllReservations()
        {
            var reservations = await _reservationService.GetAllReservations();
            return View(reservations);
        }

        public async Task<ActionResult> DeleteReservation(int id)
        {
            var deleteReservation = await _reservationService.DeleteReservation(id);
            var reservations = await _reservationService.GetAllReservations();
            return View(reservations);
        }
    }
}
