namespace Pizzeria.Models
{
    public class OrdenIngrediente
    {
        public int Id { get; set; }
        public int OrdenId { get; set; }
        public Orden? Orden { get; set; }
        public int IngredienteId { get; set; }
        public Ingrediente? Ingrediente { get; set; }
    }
}
