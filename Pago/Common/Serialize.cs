using Newtonsoft.Json;
using System;

namespace Common
{
   public static class Serialize
   {
      public static T DeserializeObject<T>(string a)
      {
         try
         {
            return JsonConvert.DeserializeObject<T>(a);
         }
         catch (JsonSerializationException)
         {
            return (T)Activator.CreateInstance(typeof(T));
         }
         catch (JsonReaderException)
         {
            return (T)Activator.CreateInstance(typeof(T));
         }
      }
      public static string SerializeObject<T>(T item)
      {
         return JsonConvert.SerializeObject(item);
      }

      public static T DeserializeObject<T>(object a)
      {
         string data = SerializeObject<object>(a);
         return DeserializeObject<T>(data);
      }
   }
}
