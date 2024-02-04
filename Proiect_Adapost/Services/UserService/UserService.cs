using Proiect_Adapost.Models.User;
using Proiect_Adapost.Repositories.UserRepository;

namespace Proiect_Adapost.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserRepository _userRepository;

        public UserService(IHttpContextAccessor httpContextAccessor, IUserRepository userRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _userRepository = userRepository;
        }
        public string GetNume()
        {
            var result = string.Empty;
            if (_httpContextAccessor.HttpContext is not null)
            {
                result = _httpContextAccessor.HttpContext.User?.Identity?.Name;
            }
            return result;
        }

        public async Task<User> GetUserById(Guid userId)
        {
            return await _userRepository.GetUserById(userId);

        }
    }
}
