using Proiect_Adapost.Models.Arhiva;
using Proiect_Adapost.Repositories.GenericRepository;

namespace Proiect_Adapost.Repositories.ArhivaRepository
{
    public interface IArhivaRepository : IGenericRepository<Arhiva>
    {
        Task<Arhiva?> GetArhivaById(Guid arhivaId);
    }
}
