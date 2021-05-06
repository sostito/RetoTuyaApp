using Microsoft.AspNetCore.Mvc;
using Model.Request;
using Services;

namespace Logistica.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class LogisticsController : Controller
   {
      readonly IDataBaseService dataBaseService;
      public LogisticsController(IDataBaseService dataBaseService)
      {
         this.dataBaseService = dataBaseService;
      }
      [HttpPost("[action]")]
      public IActionResult SaveOrder([FromBody] SaveOrderRequest saveOrderRequest)
      {
         bool isSuccess = dataBaseService.InsertOrder(saveOrderRequest);
         return StatusCode(200, isSuccess);
      }
   }
}
