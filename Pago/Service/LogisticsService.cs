using Common;
using Model.Response;
using System;

namespace Service
{
   public class LogisticsService : ILogisticsService
   {
      readonly IConsumerService consumerService;
      public LogisticsService(IConsumerService consumerService)
      {
         this.consumerService = consumerService;
      }

      public bool SaveOrder(InvoiceProductsResponse request)
      {
         try
         {
            var response = consumerService.Post(request, Constants.URI_Logistics);
            string message = response.Content.ReadAsStringAsync().Result;
            var isSuccess = Serialize.DeserializeObject<bool>(message);
            return isSuccess;
         }
         catch (Exception ex)
         {
            return false;
         }
      }
   }
}
