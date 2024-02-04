using Microsoft.EntityFrameworkCore;
using Proiect_Adapost.Data;
using Proiect_Adapost.Models.Arhiva;
using Proiect_Adapost.Repositories.GenericRepository;

namespace Proiect_Adapost.Repositories.ArhivaRepository
{
    public class ArhivaRepository : GenericRepository<Arhiva>, IArhivaRepository
    {
        public ArhivaRepository(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<Arhiva> GetArhivaById(Guid arhivaId)
        {
            return await _table
                .Include(a => a.Control)
                .FirstOrDefaultAsync(a => a.Id == arhivaId);
        }
    }
}
