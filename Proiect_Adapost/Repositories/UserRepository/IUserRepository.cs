using Proiect_Adapost.Models.User;
using Proiect_Adapost.Repositories.GenericRepository;

namespace Proiect_Adapost.Repositories.UserRepository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> GetUserById(Guid userId);
    }
}
