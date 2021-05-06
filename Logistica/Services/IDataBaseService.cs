using Model.Request;

namespace Services
{
   public interface IDataBaseService
   {
      bool InsertOrder(SaveOrderRequest request);
   }
}
