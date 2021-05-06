using Logistica.Controllers;
using Model;
using Model.Request;
using Moq;
using NUnit.Framework;
using Services;
using System.Collections.Generic;

namespace Test
{
   public class LogisticaTest
   {
      [Test]
      public void LogisticsController_HttpStatusCode_200()
      {
         //Arrange   
         var IInvoiceServiceMock = new Mock<IDataBaseService>();
         IInvoiceServiceMock.Setup(m => m.InsertOrder(It.IsAny<SaveOrderRequest>()))
         .Returns(() => { return true; });

         SaveOrderRequest payRequest = new SaveOrderRequest()
         {
            Success = true,
            TotalValue = 200000,
            Request = new PayRequest()
            {
               IdUser = 123,
               Products = new List<ProductDto>() {
                                                       new ProductDto() { Cantidad = 1, Nombre = "CPU", Precio = 2800000 },
                                                       new ProductDto() { Cantidad = 3, Nombre = "Monitor", Precio = 500000 }
                                                    }
            }
         };

         //Act
         LogisticsController logisticsController = new LogisticsController(IInvoiceServiceMock.Object);
         var response = logisticsController.SaveOrder(payRequest) as Microsoft.AspNetCore.Mvc.ObjectResult;

         //Assert
         Assert.AreEqual(true, response.Value);
      }
   }
}
