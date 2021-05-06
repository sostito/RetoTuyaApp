using Model;
using Model.Request;
using Model.Response;
using Moq;
using Newtonsoft.Json;
using NUnit.Framework;
using Service;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;

namespace Test.Service
{
   public class InvoiceServiceTest
   {
      [Test]
      public void InvoiceProducts()
      {
         //Arrange
         //
         HttpResponseMessage httpResponse = new HttpResponseMessage(HttpStatusCode.OK)
         {
            Content = new StringContent(JsonConvert.SerializeObject(new InvoiceProductsResponse() { Success = true }))
         };

         var consumerServiceMock = new Mock<IConsumerService>();
         consumerServiceMock.Setup(m => m.Post(It.IsAny<PayRequest>(), It.IsAny<string>()))
         .Returns(() => { return httpResponse; });

         PayRequest payRequest = new PayRequest()
         {
            IdUser = 123,
            Products = new List<ProductDto>() {
                                                       new ProductDto() { Cantidad = 1, Nombre = "CPU", Precio = 2800000 },
                                                       new ProductDto() { Cantidad = 3, Nombre = "Monitor", Precio = 500000 }
                                                    }
         };

         //Act
         InvoiceService InvoiceService = new InvoiceService(consumerServiceMock.Object);
         var response = InvoiceService.InvoiceProducts(payRequest);

         //Assert
         Assert.AreEqual(true, response.Success);
      }
   }
}
