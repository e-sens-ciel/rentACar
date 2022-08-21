using Web.Models;

namespace Web.Interfaces
{
    public interface IReservationService
    {
        Task<List<Reservation>> GetAllReservations();
        //Task<Reservation> DeleteReservation(int id);
        public Task<HttpResponseMessage> DeleteReservation(int id);
    }
}
