using Common;
using Microsoft.AspNetCore.Mvc;
using Model;
using Model.Response;
using Services;
using System;

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
         try
         {
            InvoiceProductsResponse response = productService.InvoiceProducts(invoiceRequest);
            return StatusCode(200, response);
         }
         catch (Exception)
         {
            return StatusCode(500, Constants.REQUEST_ERROR_MESSAGE);
         }
      }
   }
}
