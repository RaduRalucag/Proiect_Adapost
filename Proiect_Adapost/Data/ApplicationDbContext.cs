using Microsoft.EntityFrameworkCore;
using Proiect_Adapost.Models.Adapost;
using Proiect_Adapost.Models.Arhiva;
using Proiect_Adapost.Models.Conditie;
using Proiect_Adapost.Models.Orase;
using Proiect_Adapost.Models.Animal;
using Proiect_Adapost.Models.Carnet_sanatate;
using Proiect_Adapost.Models.Client;
using Proiect_Adapost.Models.AnimalClient;

namespace Proiect_Adapost.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Adapost> Adaposts { get; set; }
        public DbSet<Oras> Orase { get; set; }
        public DbSet<Conditie> Conditii { get; set; }
        public DbSet<Animal> Animale { get; set; }
        public DbSet<Carnet_sanatate> Carnete_sanatate { get; set; }
        public DbSet<Client> Clienti { get; set; }
        public DbSet<AnimalClient> AnimaleClienti { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>()
                .HasMany(c => c.AnimaleClienti)
                .WithOne(c => c.Animal)
                .HasForeignKey(c => c.AnimalId);

            modelBuilder.Entity<Client>()
                .HasMany(c => c.AnimaleClienti)
                .WithOne(c => c.Client)
                .HasForeignKey(c => c.ClientId); ;
           
            modelBuilder.Entity<Animal>()
                .HasOne(a => a.Carnet_sanatate)
                .WithOne(c => c.Animal)
                .HasForeignKey<Carnet_sanatate>(c => c.AnimalId);


            modelBuilder.Entity<Adapost>()
                .HasIndex(a => a.Nume)
                .IsUnique();

            modelBuilder.Entity<Oras>()
                .HasMany(o => o.Adaposts)
                .WithOne(a => a.Oras)
                .HasForeignKey(a => a.OrasId);

            modelBuilder.Entity<Adapost>()
                .HasOne(a => a.Conditie)
                .WithOne(c => c.Adapost)
                .HasForeignKey<Conditie>(c => c.AdapostId);

            modelBuilder.Entity<Arhiva>()
                .HasMany(c => c.Control)
                .WithOne(c => c.Arhiva)
                .HasForeignKey(c => c.ArhivaId);

            modelBuilder.Entity<Conditie>()
                .HasMany(c => c.Control)
                .WithOne(c => c.Conditie)
                .HasForeignKey(c => c.ConditieId);

            base.OnModelCreating(modelBuilder);
        }

    }
}
