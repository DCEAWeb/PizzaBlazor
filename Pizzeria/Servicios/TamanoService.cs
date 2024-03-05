using Microsoft.EntityFrameworkCore;
using Pizzeria.Data;
using Pizzeria.Models;

namespace Pizzeria.Servicios
{
    public class TamanoService : ITamano
    {
        private readonly ApplicationDbContext context;

        public TamanoService(ApplicationDbContext context)
        {
            this.context = context;
        }
        async Task<List<Tamano>> ITamano.Obtener()
        {
            return await context.Tamanos.ToListAsync();
        }
    }
}
