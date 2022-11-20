using FinalP.Services.ClasseAPI.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace FinalP.Services.ClasseAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Etudiant> Etudiants { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Etudiant>().HasData(new Etudiant
            {
                EtudiantId = 1,
                EtudiantName = "Ala Ghabi",
                Classename = "GLSI-A",
                age = 24,
            });

            modelBuilder.Entity<Etudiant>().HasData(new Etudiant
            {
                EtudiantId = 2,
                EtudiantName = "Eya Ben Hamza",
                Classename = "GLSI-A",
                age = 24,
            });
            modelBuilder.Entity<Etudiant>().HasData(new Etudiant
            {
                EtudiantId = 3,
                EtudiantName = "Raja ben Salem",
                Classename = "GLSI-A",
                age = 24,
            });
        }
    }
}
