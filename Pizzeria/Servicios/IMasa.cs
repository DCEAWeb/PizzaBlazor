using Pizzeria.Models;

namespace Pizzeria.Servicios
{
    public interface IMasa
    {
        Task<Masa> Registrar();

        Task<List<Masa>> Obtener();
    }
}
