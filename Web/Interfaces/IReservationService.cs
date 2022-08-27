using Web.Models;

namespace Web.Interfaces
{
    public interface IReservationService
    {
        public Task<HttpResponseMessage> CreateReservationObj(Reservation reservation);
        Task<List<Reservation>> GetAllReservations();
        Task<Reservation> GetReservation(int id);
        public Task<HttpResponseMessage> EditReservation(Reservation reservation);
        public Task<HttpResponseMessage> UpdateReservation(Reservation reservation);
        public Task<HttpResponseMessage> DeleteReservation(int id);

    }
}
