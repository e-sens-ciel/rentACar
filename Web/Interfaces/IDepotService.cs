using Web.Models;

namespace Web.Interfaces
{
    public interface IDepotService
    {
        Task<List<Depot>> GetAllDepots();
        public Task<HttpResponseMessage> CreateDepotObj(Depot depot);
        public Task<Depot> GetDepot(int id);
        public Task<HttpResponseMessage> EditDepot(Depot depot);
        public Task<HttpResponseMessage> UpdateDepot(Depot depot);
        public Task<HttpResponseMessage> DeleteDepot(int id);
    }
}
