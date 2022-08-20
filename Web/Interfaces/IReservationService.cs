using Web.Models;

namespace Web.Interfaces
{
    public interface IReservationService
    {
        Task<List<Reservation>> GetAllReservations();
    }
}
