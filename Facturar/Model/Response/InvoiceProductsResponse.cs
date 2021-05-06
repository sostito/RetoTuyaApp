namespace Model.Response
{
   public class InvoiceProductsResponse
   {
      public InvoiceProductsResponse()
      {
         Success = true;
      }

      public bool Success { get; set; }
      public double TotalValue { get; set; }
      public InvoiceRequest Request { get; set; }
   }
}
