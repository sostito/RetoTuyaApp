using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model
{
   public class InvoiceRequest
   {
      [Required]
      public int IdUser { get; set; }
      [Required]
      public List<ProductDto> Products { get; set; }
   }
}
