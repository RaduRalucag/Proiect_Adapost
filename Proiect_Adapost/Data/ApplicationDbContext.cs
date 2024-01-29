using Microsoft.EntityFrameworkCore;
using Proiect_Adapost.Models.Animal;

namespace Proiect_Adapost.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Animal> Animale { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
