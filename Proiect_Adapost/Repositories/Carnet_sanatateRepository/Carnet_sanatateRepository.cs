using Proiect_Adapost.Data;
using Proiect_Adapost.Models.Carnet_sanatate;
using Proiect_Adapost.Repositories.GenericRepository;

namespace Proiect_Adapost.Repositories.Carnet_sanatateRepository
{
    public class Carnet_sanatateRepository: GenericRepository<Carnet_sanatate>, ICarnet_sanatateRepository
    {
        public Carnet_sanatateRepository(ApplicationDbContext context) : base(context)
        {
           

        }
    }
}
