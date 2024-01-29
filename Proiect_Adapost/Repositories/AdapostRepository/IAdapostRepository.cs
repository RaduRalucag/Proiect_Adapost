using Proiect_Adapost.Models.Adapost;
using Proiect_Adapost.Repositories.GenericRepository;

namespace Proiect_Adapost.Repositories.AdapostRepository
{
    public interface IAdapostRepository : IGenericRepository<Adapost>
    {
        Task<List<Adapost>> GetAdapostsByOras(Guid id);
    }
}
