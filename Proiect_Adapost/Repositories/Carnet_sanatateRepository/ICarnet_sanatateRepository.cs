using Proiect_Adapost.Models.Carnet_sanatate;
using Proiect_Adapost.Repositories.GenericRepository;

namespace Proiect_Adapost.Repositories.Carnet_sanatateRepository
{
    public interface ICarnet_sanatateRepository : IGenericRepository<Carnet_sanatate>
    {
        Task<IEnumerable<Carnet_sanatate>> GetAllCarnet_sanatateAsync();
    }
}
