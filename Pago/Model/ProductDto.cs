using System.ComponentModel.DataAnnotations;

namespace Model
{
   public class ProductDto
   {
      [Required]
      public string Nombre { get; set; }
      [Required]
      public double Precio { get; set; }
      [Required]
      public int Cantidad { get; set; }
   }
}
