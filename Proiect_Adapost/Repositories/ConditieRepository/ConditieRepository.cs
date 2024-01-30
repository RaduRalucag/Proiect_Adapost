using Microsoft.EntityFrameworkCore;
using Proiect_Adapost.Data;
using Proiect_Adapost.Models.Conditie;
using Proiect_Adapost.Repositories.GenericRepository;

namespace Proiect_Adapost.Repositories.ConditieRepository
{
    public class ConditieRepository : GenericRepository<Conditie>, IConditieRepository
    {
        public ConditieRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Conditie> GetConditieById(Guid conditieId)
        {
            return await _table
                .Include(c => c.Adapost)
                .FirstOrDefaultAsync(c => c.Id == conditieId);
        }
    }
}
