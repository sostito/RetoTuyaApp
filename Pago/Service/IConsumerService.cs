using System.Net.Http;

namespace Service
{
   public interface IConsumerService
   {
      HttpResponseMessage Post(object data, string uri);
   }
}
