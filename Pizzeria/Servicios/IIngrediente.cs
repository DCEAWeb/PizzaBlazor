using Pizzeria.Models;

namespace Pizzeria.Servicios
{
    public interface IIngrediente
    {
        Task<List<Ingrediente>> Obtener();
    }
}
