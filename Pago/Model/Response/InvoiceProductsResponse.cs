using Model.Request;

namespace Model.Response
{
   public class InvoiceProductsResponse
   {
      public bool Success { get; set; }
      public double TotalValue { get; set; }
      public PayRequest Request { get; set; }
   }
}
