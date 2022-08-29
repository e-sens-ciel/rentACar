using Web.Models;

namespace Web.Interfaces
{
    public interface IVoitureService
    {
        public Task<List<Voiture>> GetAllVoitures();
        public Task<HttpResponseMessage> CreateVoitureObj(Voiture voiture);
        public Task<Voiture> GetVoiture(int id);
        public Task<HttpResponseMessage> EditVoiture(Voiture voiture);
        public Task<HttpResponseMessage> UpdateVoiture(Voiture voiture);
        public Task<HttpResponseMessage> DeleteVoiture(int id);
    }
}
