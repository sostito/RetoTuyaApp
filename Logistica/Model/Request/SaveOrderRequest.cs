using System.ComponentModel.DataAnnotations;

namespace Model.Request
{
   public class SaveOrderRequest
   {
      [Required]
      public bool Success { get; set; }
      [Required]
      public double TotalValue { get; set; }
      [Required]
      public PayRequest Request { get; set; }
   }
}
