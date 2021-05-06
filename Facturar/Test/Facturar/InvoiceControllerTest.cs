using Facturar.Controllers;
using InvoiceService;
using Model;
using Moq;
using NUnit.Framework;
using Services;
using System.Collections.Generic;

namespace Test.Facturar
{
   public class InvoiceControllerTest
   {
      [Test]
      public void InvoiceController_HttpStatusCode_200()
      {
         InvoiceRequest invoiceRequest = new InvoiceRequest()
         {
            IdUser = 123,
            Products = new List<ProductDto>() {
                                                       new ProductDto() { Cantidad = 1, Nombre = "CPU", Precio = 2800000 },
                                                       new ProductDto() { Cantidad = 3, Nombre = "Monitor", Precio = 500000 }
                                                    }
         };

         InvoiceController invoiceController = new InvoiceController(new ProductService());
         var response = invoiceController.InvoiceProducts(invoiceRequest) as Microsoft.AspNetCore.Mvc.ObjectResult;

         Assert.AreEqual(200, response.StatusCode);
      }
   }
}
