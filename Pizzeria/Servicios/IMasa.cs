using Pizzeria.Models;

namespace Pizzeria.Servicios
{
    public interface IMasa
    {
        Task<Masa> Registrar(Masa masa);

        Task<List<Masa>> Obtener();
    }
}
