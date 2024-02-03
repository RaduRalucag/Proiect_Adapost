using Proiect_Adapost.Models.Adapost;
using Proiect_Adapost.Models.Carnet_sanatate;
using Proiect_Adapost.Models.Carnet_sanatate.Dto;
using Proiect_Adapost.Repositories.AnimalRepository;
using Proiect_Adapost.Repositories.Carnet_sanatateRepository;

namespace Proiect_Adapost.Services.Carnet_sanatateService
{
    public class Carnet_sanatateService: ICarnet_sanatateService
    {
        private readonly ICarnet_sanatateRepository _carnet_sanatateRepository;
        private readonly IAnimalRepository _animalRepository;

        public Carnet_sanatateService(ICarnet_sanatateRepository carnet_sanatateRepository, IAnimalRepository animalRepository)
        {
            _carnet_sanatateRepository = carnet_sanatateRepository;
            _animalRepository = animalRepository;
        }


        
        public async Task<IEnumerable<Carnet_sanatate>> GetAllCarnet_sanatate()
        {
            return await _carnet_sanatateRepository.GetAllCarnet_sanatateAsync();
        }



        public async Task CreateCarnet_sanatate(Guid animalId, Carnet_sanatate carnet_sanatate)
        {
            var animal = await _animalRepository.FindByIdAsync(animalId);
            carnet_sanatate.Animal = animal;
            await _carnet_sanatateRepository.CreateAsync(carnet_sanatate);
            await _carnet_sanatateRepository.SaveAsync();
        }

        public async Task DeleteCarnet_sanatate(Carnet_sanatate carnet_sanatate)
        {
            _carnet_sanatateRepository.Delete(carnet_sanatate);
            await _carnet_sanatateRepository.SaveAsync();
        }

        public async Task<Carnet_sanatate> GetCarnet_sanatateById(Guid id)
        {
            return await _carnet_sanatateRepository.FindByIdAsync(id);
        }

        public async Task<Carnet_sanatate> GetAnimal(Guid id)
        {
            return await _carnet_sanatateRepository.FindByIdAsync(id);
        }
    }
}
