using Microsoft.EntityFrameworkCore;
using Proiect_Adapost.Data;
using Proiect_Adapost.Models.Adapost;
using Proiect_Adapost.Models.Orase;
using Proiect_Adapost.Repositories.GenericRepository;

namespace Proiect_Adapost.Repositories.AdapostRepository
{
    public class AdapostRepository : GenericRepository<Adapost>, IAdapostRepository
    {
        private Oras _context;

        public AdapostRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
