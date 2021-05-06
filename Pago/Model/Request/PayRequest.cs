
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.Request
{
   public class PayRequest
   {
      [Required]
      public int IdUser { get; set; }
      [Required]
      public List<ProductDto> Products { get; set; }
   }
}
