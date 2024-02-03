using Microsoft.EntityFrameworkCore;
using Proiect_Adapost.Data;
using Proiect_Adapost.Models.Animal;
using Proiect_Adapost.Repositories.GenericRepository;

namespace Proiect_Adapost.Repositories.AnimalRepository
{
    public class AnimalRepository: GenericRepository<Animal>, IAnimalRepository
    {
        public AnimalRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Animal> GetAnimalById(Guid animalId)
        {
            return await _table
                .Include(a => a.AnimaleClienti)
                .FirstOrDefaultAsync(a => a.Id == animalId);
        }
    }
}

