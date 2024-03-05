using Microsoft.EntityFrameworkCore;
using Pizzeria.Data;
using Pizzeria.Models;

namespace Pizzeria.Servicios
{
    public class MasaService : IMasa
    {
        private readonly ApplicationDbContext context;

        public MasaService(ApplicationDbContext context)
        {
            this.context = context;
        }
        async Task<List<Masa>> IMasa.Obtener()
        {
            List<Masa> lista = new List<Masa>();
            lista = await context.Masas.ToListAsync();
            return lista;
        }

        Task<Masa> IMasa.Registrar()
        {
            throw new NotImplementedException();
        }
    }
}
