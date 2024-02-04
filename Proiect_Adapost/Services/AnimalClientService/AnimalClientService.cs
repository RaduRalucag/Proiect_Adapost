using Proiect_Adapost.Models.Animal;
using Proiect_Adapost.Models.AnimalClient;
using Proiect_Adapost.Models.Carnet_sanatate;
using Proiect_Adapost.Repositories.AnimalClientRepository;
using Proiect_Adapost.Repositories.AnimalRepository;
using Proiect_Adapost.Repositories.ClientRepository;

namespace Proiect_Adapost.Services.AnimalClientService
{
    public class AnimalClientService: IAnimalClientService
    {
        private readonly IAnimalClientRepository _animalclientRepository;
        private readonly IAnimalRepository _animalRepository;
        private readonly IClientRepository _clientRepository;

        public AnimalClientService(IAnimalClientRepository animalclientRepository, IAnimalRepository animalRepository, IClientRepository clientRepository)
        {
            _animalclientRepository = animalclientRepository;
            _animalRepository = animalRepository;
            _clientRepository = clientRepository;
        }

        public async Task CreateAnimalClient(AnimalClient animalclient, Guid animalId, Guid clientId)
        {
            var animal = await _animalRepository.GetAnimalById(animalId);
            animalclient.Animal = animal;
            var client = await _clientRepository.GetClientById(clientId);
            animalclient.Client = client;
            await _animalclientRepository.CreateAsync(animalclient);
            await _animalclientRepository.SaveAsync();

        }

        public async Task DeleteAnimalClient(AnimalClient animalclient)
        {
            _animalclientRepository.Delete(animalclient);
            await _animalclientRepository.SaveAsync();
        }

        public async Task<AnimalClient> GetAnimalClientById(Guid id)
        {
            return await _animalclientRepository.FindByIdAsync(id);
        }

        public async Task<IEnumerable<AnimalClient>> GetAnimalsClients()
        {
            return (List<AnimalClient>)await _animalclientRepository.GetAllAsync();
        }

        public async Task UpdateAnimalClient(AnimalClient animalclient)
        {
            _animalclientRepository.Update(animalclient);
            await _animalclientRepository.SaveAsync();
        }
    }
}
