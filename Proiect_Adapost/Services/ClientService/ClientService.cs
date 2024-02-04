using Proiect_Adapost.Models.Animal;
using Proiect_Adapost.Models.Client;
using Proiect_Adapost.Models.Orase;
using Proiect_Adapost.Repositories.ClientRepository;
using Proiect_Adapost.Repositories.OrasRepository;

namespace Proiect_Adapost.Services.ClientService
{
    public class ClientService: IClientService
    {

        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task CreateClient(Client client)
        {
            await _clientRepository.CreateAsync(client);
            await _clientRepository.SaveAsync();
        }

        public async Task DeleteClient(Client client)
        {
            _clientRepository.Delete(client);
            await _clientRepository.SaveAsync();
        }
        public async Task<Client> GetClientById(Guid id)
        {
            return await _clientRepository.FindByIdAsync(id);
        }

        public async Task<List<Client>> GetClienti()
        {
            return (List<Client>)await _clientRepository.GetAllAsync();
        }

        public async Task UpdateClient(Client client)
        {
            _clientRepository.Update(client);
            await _clientRepository.SaveAsync();
        }
    }
}
