using Microsoft.AspNetCore.Mvc;
using Model;
using Model.Response;
using Services;

namespace Facturar.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class InvoiceController : ControllerBase
   {
      readonly IProductService productService;
      public InvoiceController(IProductService productService)
      {
         this.productService = productService;
      }

      [HttpPost("[action]")]
      public IActionResult InvoiceProducts([FromBody] InvoiceRequest invoiceRequest)
      {
         InvoiceProductsResponse response = productService.InvoiceProducts(invoiceRequest);
         return StatusCode(200, response);
      }
   }
}
