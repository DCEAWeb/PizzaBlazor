using Microsoft.EntityFrameworkCore;
using Pizzeria.Models;

namespace Pizzeria.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {      
        }

        public DbSet<Tamano> Tamanos { get; set; }
        public DbSet<Masa> Masas { get; set; }
        public DbSet<Ingrediente> Ingredientes { get; set;}
        public DbSet<Pizza> Pizzas { get; set; }
    }
}
