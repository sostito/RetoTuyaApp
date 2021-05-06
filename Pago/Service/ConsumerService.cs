using Common;
using System;
using System.Net.Http;
using System.Text;

namespace Service
{
   public class ConsumerService : IConsumerService
   {
      public HttpResponseMessage Post(object data, string uri)
      {
         try
         {
            using (HttpClient client = new HttpClient())
            {
               client.Timeout = TimeSpan.FromSeconds(90);
               HttpRequestMessage request = new HttpRequestMessage
               {
                  Method = HttpMethod.Post,
                  RequestUri = new Uri(uri),
                  Content = new StringContent(Serialize.SerializeObject(data), Encoding.UTF8, Constants.CONTENT_TYPE)
               };

               return client.SendAsync(request).Result;
            }
         }
         catch (Exception ex)
         {
            throw;
         }
      }
   }
}
