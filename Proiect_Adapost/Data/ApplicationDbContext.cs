using Microsoft.EntityFrameworkCore;

namespace Proiect_Adapost.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public object Adaposts { get; internal set; }
    }
}
