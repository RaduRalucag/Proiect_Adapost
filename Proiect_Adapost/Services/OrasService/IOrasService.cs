using Proiect_Adapost.Models.Orase;

namespace Proiect_Adapost.Services.OrasService
{
    public interface IOrasService
    {
        Task CreateOras(Oras oras);
        Task DeleteOras(Oras oras);
        Task<Oras> GetOrasById(Guid id);
        Task<IEnumerable<Oras>> GetOrase();
    }
}
