using Newtonsoft.Json;
using System;

namespace Common
{
   public static class Serialize
   {
      public static string SerializeObject<T>(T item)
      {
         return JsonConvert.SerializeObject(item);
      }
   }
}
