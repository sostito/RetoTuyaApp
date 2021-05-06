using Common;
using Model.Request;
using Model.Response;

namespace Service
{
   public class InvoiceService : IInvoiceService
   {
      readonly IConsumerService consumerService;
      public InvoiceService(IConsumerService consumerService)
      {
         this.consumerService = consumerService;
      }

      public InvoiceProductsResponse InvoiceProducts(PayRequest request)
      {
         try
         {
            var response = consumerService.Post(request, Constants.URI_INVOICE);
            string message = response.Content.ReadAsStringAsync().Result;
            var otro = Serialize.DeserializeObject<InvoiceProductsResponse>(message);
            return otro;
         }
         catch (System.Exception ex)
         {

            throw;
         }
         return null;
      }
   }
}
