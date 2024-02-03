using Proiect_Adapost.Models.Animal;
using Proiect_Adapost.Models.Client;
using Proiect_Adapost.Repositories.GenericRepository;

namespace Proiect_Adapost.Repositories.ClientRepository
{
    public interface IClientRepository : IGenericRepository<Client>
    {
        Task<Client> GetClientById(Guid clientId);
    }
}
