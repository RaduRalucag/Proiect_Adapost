using Proiect_Adapost.Models.Animal;
using Proiect_Adapost.Models.AnimalClient;
using Proiect_Adapost.Models.AnimalClient.Dto;
using Proiect_Adapost.Models.Client;

namespace Proiect_Adapost.Services.AnimalClientService
{
    public interface IAnimalClientService
    {
        Task CreateAnimalClient(AnimalClient animalClient, Guid animalId, Guid clientlId);
        Task DeleteAnimalClient(AnimalClient animalClient);
        Task<AnimalClient> GetAnimalClientById(Guid id);
        Task<IEnumerable<AnimalClient>> GetAnimalsClients();
        Task UpdateAnimalClient(AnimalClient animalClient);

    }
}
