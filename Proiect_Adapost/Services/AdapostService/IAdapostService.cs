using Proiect_Adapost.Models.Adapost;

namespace Proiect_Adapost.Services.AdapostService
{
    public interface IAdapostService
    {
        Task CreateAdapost(Adapost adapost, Guid orasId);
        Task DeleteAdapost(Adapost adapost);
        Task<Adapost> GetOrasById(Guid id);
        Task<List<Adapost>> GetAdaposts();
        Task<List<Adapost>> GetAdapostsByOras(Guid id);
    }
}
