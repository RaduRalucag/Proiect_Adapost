using Proiect_Adapost.Models.Animal;
using Proiect_Adapost.Repositories.AnimalRepository;

namespace Proiect_Adapost.Services
{
    public class AnimalService: IAnimalService
    {
        private readonly IAnimalRepository _animalRepository;

        public AnimalService(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }

        public async Task<IEnumerable<Animal>> GetAllAnimals()
        {
            return await _animalRepository.GetAllAsync();
        }

        public async Task CreateAnimal(Animal animal)
        {
            await _animalRepository.CreateAsync(animal);
            await _animalRepository.SaveAsync();
        }

        public async Task<Animal> GetAnimal(Guid id)
        {
            return await _animalRepository.FindByIdAsync(id);
        }

        public async Task CreateAllAnimals(IList<Animal> animals)
        {
            foreach (var animal in animals)
            {
                await _animalRepository.CreateAsync(animal);

            }
            await _animalRepository.SaveAsync();
        }

    }
}
