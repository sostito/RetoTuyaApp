using System.Collections.Generic;

namespace Model.Request
{
   public class PayRequest
   {
      public int IdUser { get; set; }
      public List<ProductDto> Products { get; set; }
   }
}
