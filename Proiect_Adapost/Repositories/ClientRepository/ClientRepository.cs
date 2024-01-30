using Proiect_Adapost.Data;
using Proiect_Adapost.Models.Client;
using Proiect_Adapost.Repositories.GenericRepository;

namespace Proiect_Adapost.Repositories.ClientRepository
{
    public class ClientRepository: GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
