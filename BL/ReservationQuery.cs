using DAL;
using MODELS;
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
    }
}
