using Proiect_Adapost.Models.Adapost;

namespace Proiect_Adapost.Services.AdapostService
{
    public interface IAdapostService
    {
        Task CreateAdapost(Adapost adapost, Guid orasId, Guid conditieId);
        Task DeleteAdapost(Adapost adapost);
        Task<Adapost> GetAdapostById(Guid id);
        Task<List<Adapost>> GetAdaposts();
        Task UpdateAdapost(Adapost adapost);
    }
}
