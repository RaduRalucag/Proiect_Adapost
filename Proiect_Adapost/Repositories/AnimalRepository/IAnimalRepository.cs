using Proiect_Adapost.Models.Animal;
using Proiect_Adapost.Repositories.GenericRepository;

namespace Proiect_Adapost.Repositories.AnimalRepository
{
    public interface IAnimalRepository : IGenericRepository<Animal>
    {
        Task<Animal?> GetAnimalById(Guid animalId);
    }
}
