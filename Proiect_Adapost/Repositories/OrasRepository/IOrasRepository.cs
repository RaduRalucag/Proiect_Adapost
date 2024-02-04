using Proiect_Adapost.Models.Orase;
using Proiect_Adapost.Repositories.GenericRepository;

namespace Proiect_Adapost.Repositories.OrasRepository
{
    public interface IOrasRepository : IGenericRepository<Oras>
    {
        Task<IEnumerable<Oras>> GetAllOraseAsync();
        Task<Oras> GetOrasById(Guid orasId);
    }
}
