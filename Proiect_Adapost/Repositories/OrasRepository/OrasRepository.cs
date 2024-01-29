using Proiect_Adapost.Data;
using Proiect_Adapost.Models.Orase;
using Proiect_Adapost.Repositories.GenericRepository;

namespace Proiect_Adapost.Repositories.OrasRepository
{
    public class OrasRepository : GenericRepository<Oras>, IOrasRepository
    {
        public OrasRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
