using System.ComponentModel.DataAnnotations;

namespace Pizzeria.Models
{
	public class Masa
	{
		public int Id { get; set; }
		[Required(ErrorMessage ="El nombre de la masa es requerido")]
		public string? Nombre { get; set; }
		[Range(1.0,float.MaxValue,ErrorMessage ="Revisa el precio")]
		public float Precio { get; set; }
    }
}
