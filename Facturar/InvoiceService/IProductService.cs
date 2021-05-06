using Model;
using Model.Response;

namespace Services
{
   public interface IProductService
   {
      InvoiceProductsResponse InvoiceProducts(InvoiceRequest request);
   }
}
