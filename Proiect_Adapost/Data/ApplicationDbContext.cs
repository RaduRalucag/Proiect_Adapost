using Microsoft.EntityFrameworkCore;
using Proiect_Adapost.Models.Adapost;

namespace Proiect_Adapost.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Adapost> Adaposts { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adapost>()
                .HasIndex(a => a.Nume)
                .IsUnique();

            base.OnModelCreating(modelBuilder);
        }

    }
}
