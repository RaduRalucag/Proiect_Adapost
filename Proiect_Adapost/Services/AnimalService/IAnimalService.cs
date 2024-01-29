using System.Threading.Tasks;
using Proiect_Adapost.Models.Animal;

namespace Proiect_Adapost.Services.AnimalService
{
    public interface IAnimalService
    {

        Task CreateAllAnimals(IList<Animal> animals);
        Task CreateAnimal(Animal animal);
        Task<IEnumerable<Animal>> GetAllAnimals();
        Task DeleteAnimal(Animal animal);
        Task<Animal> GetAnimal(Guid id);
    }
}
