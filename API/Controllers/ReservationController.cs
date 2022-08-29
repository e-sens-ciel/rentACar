using BL;
using DAL;
using Microsoft.AspNetCore.Mvc;
using MODELS;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReservationController : ControllerBase
    {
        private readonly ReservationQuery _reservations;
        public ReservationController(ReservationQuery reservationQuery)
        {
            _reservations = reservationQuery;
        }

        [HttpGet("[action]")]
        public IActionResult GetAllReservations()
        {
            List<Reservation> reservations = _reservations.GetAll();
            return Ok(reservations);
        }


        [HttpGet("{id}")]
        public IActionResult GetReservation(int id)
        {

            Reservation reservation = _reservations.GetById(id);
            return Ok(reservation);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateReservation(Reservation reservation)
        {
            _reservations.UpdateReservation(reservation);
   
            return Ok();
        }

        [HttpPost("[action]")]
        public IActionResult CreateReservation(Reservation reservation)
        {
            _reservations.CreateReservation(reservation);
            return Ok();
        }

        [HttpDelete("[action]")]
        public IActionResult DeleteReservation(int id)
        {
            _reservations.Delete(id);
            return Ok();
        }
    }
}
