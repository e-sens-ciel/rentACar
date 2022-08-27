using DAL;
using MODELS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BL
{
    public class ReservationQuery
    {
        private readonly CarContext _carContext;
        public ReservationQuery(CarContext carContext)
        {
            _carContext = carContext;
        }

        public List<Reservation> GetAll()
        {
            List<Reservation> reservations = _carContext.Reservation.ToList();

            return reservations;
        }

        public Reservation GetById(int id )
        {
            Reservation reservation = _carContext.Reservation.Find(id);

            if (reservation == null)
            {
                throw new NotImplementedException();
            }

            return reservation;
        }

        public async Task<IActionResult> Create(Reservation reservation)
        {
            if (reservation == null)
            {
                throw new NotImplementedException();
            }
            _carContext.Reservation.Add(reservation);
            await _carContext.SaveChangesAsync();

            return NoContent();
        }
        public async Task UpdateReservation(Reservation reservation)
        {
            _carContext.Entry(reservation).State = EntityState.Modified;
            await _carContext.SaveChangesAsync();
        }

  
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                throw new NotImplementedException();
            }
            List<Reservation> reservations = _carContext.Reservation.ToList();
            var reserv = reservations.Find(x => x.ReservationID == id);
            var removed = _carContext.Reservation.Remove(reserv);
            await _carContext.SaveChangesAsync();

            return NoContent();
        }

        private IActionResult NoContent()
        {
            throw new NotImplementedException();
        }
    }
}
