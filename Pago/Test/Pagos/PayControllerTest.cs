using Model;
using Model.Request;
using Model.Response;
using Moq;
using NUnit.Framework;
using Pago.Controllers;
using Service;
using System.Collections.Generic;

namespace Test
{
   public class PayTest
   {
      [Test]
      public void PayController()
      {
         //Arrange   
         var IInvoiceServiceMock = new Mock<IInvoiceService>();
         IInvoiceServiceMock.Setup(m => m.InvoiceProducts(It.IsAny<PayRequest>()))
         .Returns(() => { return new InvoiceProductsResponse(); });

         var ILogisticsServiceMock = new Mock<ILogisticsService>();
         ILogisticsServiceMock.Setup(m => m.SaveOrder(It.IsAny<InvoiceProductsResponse>()))
            .Returns(() => { return true; });

         PayRequest payRequest = new PayRequest()
         {
            IdUser = 123,
            Products = new List<ProductDto>() {
                                                       new ProductDto() { Cantidad = 1, Nombre = "CPU", Precio = 2800000 },
                                                       new ProductDto() { Cantidad = 3, Nombre = "Monitor", Precio = 500000 }
                                                    }
         };

         //Act
         PayController payController = new PayController(IInvoiceServiceMock.Object, ILogisticsServiceMock.Object);
         var response = payController.Pay(payRequest);
         var otro = response as Microsoft.AspNetCore.Mvc.ObjectResult;

         //Assert
         Assert.AreEqual(200, otro.StatusCode);
      }
   }
}
