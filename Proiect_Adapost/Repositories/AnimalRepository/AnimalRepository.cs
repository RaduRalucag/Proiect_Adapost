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
    }
}
