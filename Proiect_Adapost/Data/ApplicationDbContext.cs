using Microsoft.EntityFrameworkCore;
using Proiect_Adapost.Models.Adapost;
using Proiect_Adapost.Models.Arhiva;
using Proiect_Adapost.Models.Conditie;
using Proiect_Adapost.Models.Control;
using Proiect_Adapost.Models.Orase;

namespace Proiect_Adapost.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Adapost> Adaposts { get; set; }
        public DbSet<Oras> Orase { get; set; }
        public DbSet<Conditie> Conditii { get; set; }
        public DbSet<Arhiva> Arhive { get; set; }
        public DbSet<Control> Controls { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
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
