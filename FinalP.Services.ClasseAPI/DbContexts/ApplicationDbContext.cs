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
    }
}
