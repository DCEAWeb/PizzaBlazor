namespace Pizzeria.Models
{
    public class Orden
    {
        public int Id { get; set; }
        public DateTime FechaOrden { get; set; }
        public string Cliente { get; set; }
        public int TamanoId { get; set; }
        public Tamano? Tamano { get; set; }
        public int MasaId { get; set; }
        public Masa? Masa { get; set; }
        public float Precio { get; set; }
    }
}
