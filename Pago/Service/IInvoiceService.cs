using Model.Request;
using Model.Response;

namespace Service
{
   public interface IInvoiceService
   {
      InvoiceProductsResponse InvoiceProducts(PayRequest request);
   }
}
