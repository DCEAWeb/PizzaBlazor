using Microsoft.EntityFrameworkCore;
using Pizzeria.Data;
using Pizzeria.Models;

namespace Pizzeria.Servicios
{
    public class IngredienteService(ApplicationDbContext context) : IIngrediente
    {
        async Task<List<Ingrediente>> IIngrediente.Obtener()
        {
            return await context.Ingredientes.ToListAsync();
        }
    }
}
