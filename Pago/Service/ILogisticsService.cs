using Model.Response;

namespace Service
{
   public interface ILogisticsService
   {
      bool SaveOrder(InvoiceProductsResponse request);
   }
}
