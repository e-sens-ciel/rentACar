using Web.Models;

namespace Web.Interfaces
{
    public interface IReservationService
    {
        Task<List<Reservation>> GetAllReservations();
        Task<Reservation> GetReservation(int id);
        public Task<HttpResponseMessage> EditReservation(Reservation reservation);
        public Task<HttpResponseMessage> UpdateReservation(Reservation reservation);
        public Task<HttpResponseMessage> DeleteReservation(int id);

    }
}
