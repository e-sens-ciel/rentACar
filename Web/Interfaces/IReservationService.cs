using Web.Models;

namespace Web.Interfaces
{
    public interface IReservationService
    {
        Task<List<Reservation>> GetAllReservations();
        public Task<HttpResponseMessage> UpdateReservation(Reservation reservation);
        public Task<HttpResponseMessage> DeleteReservation(int id);

    }
}
