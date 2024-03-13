using Pizzeria.Models;

namespace Pizzeria.Servicios
{
    public interface IOrden
    {
        Task<int> RegistrarOrden(Pizza pizza, string cliente);
    }
}
