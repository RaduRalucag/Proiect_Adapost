using Proiect_Adapost.Models.Conditie;
using Proiect_Adapost.Repositories.GenericRepository;

namespace Proiect_Adapost.Repositories.ConditieRepository
{
    public interface IConditieRepository : IGenericRepository<Conditie>
    {
       Task<Conditie> GetConditieById(Guid conditieId);
        
    }
}
