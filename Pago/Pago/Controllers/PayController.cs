using Common;
using Microsoft.AspNetCore.Mvc;
using Model.Request;
using Service;
using System;

namespace Pago.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class PayController : ControllerBase
   {
      readonly IInvoiceService invoiceService;
      readonly ILogisticsService logisticsService;
      public PayController(IInvoiceService invoiceService, ILogisticsService logisticsService)
      {
         this.invoiceService = invoiceService;
         this.logisticsService = logisticsService;
      }

      [HttpPost("[action]")]
      public IActionResult Pay([FromBody] PayRequest payRequest)
      {
         try
         {
            var response = invoiceService.InvoiceProducts(payRequest);
            logisticsService.SaveOrder(response);
            return StatusCode(200, response);
         }
         catch (Exception ex)
         {
            return StatusCode(500, Constants.REQUEST_ERROR_MESSAGE);
         }
      }
   }
}
