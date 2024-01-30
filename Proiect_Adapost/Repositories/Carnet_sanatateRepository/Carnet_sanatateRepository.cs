using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<Carnet_sanatate>> GetAllCarnet_sanatateAsync()
        {
            return await _table.Include(a => a.Animal).AsNoTracking().ToListAsync();
        }
    }
}
