using Microsoft.EntityFrameworkCore;
using Proiect_Adapost.Models.Adapost;
using Proiect_Adapost.Models.Orase;
using Proiect_Adapost.Models.Animal;

namespace Proiect_Adapost.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Adapost> Adaposts { get; set; }
        public DbSet<Oras> Orase { get; set; }
        public DbSet<Animal> Animale { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Adapost>()
                .HasIndex(a => a.Nume)
                .IsUnique();

            modelBuilder.Entity<Oras>()
                .HasMany(o => o.Adaposts)
                .WithOne(a => a.Oras)
                .HasForeignKey(a => a.OrasId);

            base.OnModelCreating(modelBuilder);
        }

    }
}
