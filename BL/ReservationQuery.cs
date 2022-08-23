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
        public async Task UpdateReservation(int id, Reservation reservation)
        {
            //var entity = _carContext.Reservation.Find(id);
            //entity = new Reservation
            //{
            //    DateDebut = 
            //};
            if (id != reservation.ReservationID)
            {
                throw new NotImplementedException();
            }

            _carContext.Entry(reservation).State = EntityState.Modified;

            await _carContext.SaveChangesAsync();

        }

  
        public async Task<IActionResult> Delete(int id)
        {
            //var reservation = await _carContext.Reservation.FindAsync(id);
            //_carContext.Reservation.Remove(entity);
            //await _carContext.SaveChangesAsync();
            //var reservation = await _carContext.Reservation.SingleOrDefaultAsync(m => m.ReservationID == id);
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
