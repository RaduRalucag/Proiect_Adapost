using Microsoft.EntityFrameworkCore;
using Proiect_Adapost.Data;
using Proiect_Adapost.Models.AnimalClient;
using Proiect_Adapost.Models.Carnet_sanatate;
using Proiect_Adapost.Repositories.GenericRepository;

namespace Proiect_Adapost.Repositories.AnimalClientRepository
{
    public class AnimalClientRepository: GenericRepository<AnimalClient>, IAnimalClientRepository
    {
        public AnimalClientRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<AnimalClient>> GetAllAnimalsClientsAsync()
        {
            //vreau sa iau toate animalele si clientii lor cu return

            return await _table.Include(a => a.Animal).AsNoTracking().ToListAsync();
        }
    }
}
