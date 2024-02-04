using Proiect_Adapost.Models.Animal;
using Proiect_Adapost.Models.Client;
using Proiect_Adapost.Models.Orase;

namespace Proiect_Adapost.Services.ClientService
{
    public interface IClientService
    {
        Task CreateClient(Client client);
        Task DeleteClient(Client client);
        Task<Client> GetClientById(Guid id);
        Task<List<Client>> GetClienti();
        Task UpdateClient(Client client);
    }
}
