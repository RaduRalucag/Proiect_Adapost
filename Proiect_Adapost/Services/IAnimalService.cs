using System.Threading.Tasks;
using Proiect_Adapost.Models.Animal;

namespace Proiect_Adapost.Services
{
    public interface IAnimalService
    {

        Task CreateAllAnimals(IList<Animal> animals);
        Task CreateAnimal(Animal animal);
        Task<IEnumerable<Animal>> GetAllAnimals();

        Task<Animal> GetAnimal(Guid id);
    }
}
