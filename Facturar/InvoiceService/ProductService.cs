using Model;
using Model.Response;
using Services;
using System.Linq;

namespace InvoiceService
{
   public class ProductService : IProductService
   {
      public InvoiceProductsResponse InvoiceProducts(InvoiceRequest request)
      {
         try
         {
            return new InvoiceProductsResponse()
            {
               Request = request,
               TotalValue = request.Products.Sum(x => (x.Cantidad * x.Precio))
            };
         }
         catch (System.Exception)
         {
            return new InvoiceProductsResponse()
            {
               Success = false
            };
         }
      }
   }
}
