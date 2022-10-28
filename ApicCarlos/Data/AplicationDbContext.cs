using DomainId.Modelo;
using Microsoft.EntityFrameworkCore;

namespace ApicCarlos.Data
{
    public class AplicationDbContext : DbContext
    {
       public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) { }

        public DbSet<Personaje> personajes { get; set; }
        public DbSet<Genero> generos { get; set; }

    }
}
