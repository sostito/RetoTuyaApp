using Common;
using Model.Request;
using System;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Services
{
   public class DataBaseService : IDataBaseService
   {
      readonly IConfiguration configuration;
      public DataBaseService(IConfiguration configuration)
      {
         this.configuration = configuration;
      }

      public bool InsertOrder(SaveOrderRequest request)
      {
         using (SqlConnection connection = new SqlConnection(configuration["ConnectionStrings:DataBase"]))
         {
            try
            {
               connection.Open();
               string success = request.Success ? "1" : "0";
               string query = $"INSERT INTO Pedidos(Facturado, ValorTotal, Productos) VALUES ({success}, {request.TotalValue}, '{Serialize.SerializeObject(request.Request)}')";
               SqlCommand command = new SqlCommand(query, connection);
               int affectedRows = command.ExecuteNonQuery();
               return affectedRows > 0;
            }
            catch (Exception)
            {
               return false;
            }
         }
      }
   }
}
