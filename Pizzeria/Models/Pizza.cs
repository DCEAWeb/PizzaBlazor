namespace Pizzeria.Models
{
	public class Pizza
	{
		public int Id { get; set; }
        public int IdMasa { get; set; }
        public Masa? Masa { get; set; }
        public int TamanoId { get; set; }
        public Tamano? Tamano { get; set; }
        public List<Ingrediente> Ingredientes { get; set; }
        public float Precio { get; set; }
    }
}
