using Proiect_Adapost.Models.Adapost;

namespace Proiect_Adapost.Services.AdapostService
{
    public interface IAdapostService
    {
        Task CreateAllAdapost(IList<Adapost> adaposts);
        Task CreateAdapost(Adapost adapost);
        Task DeleteAdapost(Adapost adapost);
        Task<Adapost> GetAdapostById(Guid id);
        Task<List<Adapost>> GetAdaposts();
        
    }
}
