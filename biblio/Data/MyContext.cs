using Microsoft.EntityFrameworkCore;
using biblio.Models;
namespace biblio.Data
{
    public class MyContext : DbContext
    {
        public DbSet<Livre> Livres { get; set; }
        public DbSet<Adherant> Adherants { get; set; }
        public DbSet<Emprunt> Emprunts { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public MyContext(DbContextOptions<MyContext> options) : base(options) 
        {
            
        }
    }
}
