using Pizzeria.Models;

namespace Pizzeria.Servicios
{
    public interface ITamano
    {
        Task<List<Tamano>> Obtener();
    }
}
