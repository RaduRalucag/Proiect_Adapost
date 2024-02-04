using Microsoft.EntityFrameworkCore;
using Proiect_Adapost.Data;
using Proiect_Adapost.Models.User;
using Proiect_Adapost.Repositories.GenericRepository;

namespace Proiect_Adapost.Repositories.UserRepository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<User> GetUserById(Guid userId)
        {
            return await _table.FirstOrDefaultAsync(u => u.Id == userId);
        }
    }
}
