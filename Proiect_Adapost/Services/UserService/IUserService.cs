
using Proiect_Adapost.Models.User;

namespace Proiect_Adapost.Services.UserService
{
    public interface IUserService
    {
        string GetNume();
        Task<User> GetUserById(Guid userId);
    }
}
