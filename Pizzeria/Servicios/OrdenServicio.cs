using Pizzeria.Data;
using Pizzeria.Models;

namespace Pizzeria.Servicios
{
    public class OrdenServicio(ApplicationDbContext context) : IOrden
    {
        private readonly ApplicationDbContext context = context;

        async Task<int> IOrden.RegistrarOrden(Pizza pizza, string cliente)
        {
            Orden orden = new Orden();

            orden.FechaOrden = DateTime.Now;
            orden.Cliente = cliente;
            orden.TamanoId = pizza.TamanoId;
            orden.MasaId = pizza.IdMasa;
            orden.Precio = pizza.Precio;

            context.Ordenes.Add(orden);
            await context.SaveChangesAsync();

            List<OrdenIngrediente> ordenIngrediente = new List<OrdenIngrediente>();
            foreach(var item in pizza.Ingredientes)
            {
                ordenIngrediente.Add(new OrdenIngrediente 
                { OrdenId = orden.Id, IngredienteId = item.Id });
            }

            await context.OrdenIngredientes.AddRangeAsync(ordenIngrediente);
            await context.SaveChangesAsync();

            return orden.Id;
        }
    }
}
