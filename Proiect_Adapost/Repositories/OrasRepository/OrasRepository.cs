using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<Oras>> GetAllOraseAsync()
        {
            return await _table
                .Include(o => o.Adaposts)
                .ToListAsync();
        }

        public async Task<Oras> GetOrasById(Guid orasId)
        {
            return await _table
                .Include(o => o.Adaposts)
                .FirstOrDefaultAsync(o => o.Id == orasId);
        }
    }
}
