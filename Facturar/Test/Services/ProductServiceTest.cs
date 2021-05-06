using InvoiceService;
using Model;
using Model.Response;
using NUnit.Framework;
using System.Collections.Generic;

namespace Test
{
   public class ProductServiceTest
   {
      [Test]
      public void ProductService_Calculate_Ok()
      {
         //Arrange 
         ProductService productService = new ProductService();
         InvoiceRequest invoiceRequest = new InvoiceRequest() { IdUser = 123, Products = new List<ProductDto>() { new ProductDto() { Cantidad = 2, Nombre = "CPU", Precio = 1000000 } } };

         //Act
         InvoiceProductsResponse invoiceProductsResponse = productService.InvoiceProducts(invoiceRequest);

         //Assert
         Assert.AreEqual(true, invoiceProductsResponse.Success);
         Assert.AreEqual(2000000, invoiceProductsResponse.TotalValue);
      }
   }
}
