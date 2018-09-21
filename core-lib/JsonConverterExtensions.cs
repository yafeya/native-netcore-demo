using Newtonsoft.Json;
using System;

namespace core_lib
{
    public static class JsonConverterExtensions
    {
        public static string ToJson<T>(this T instance) where T : class
        {
            var result = string.Empty;

            try
            {
                result = JsonConvert.SerializeObject(instance);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return result;
        }

        public static T FromJson<T>(this string json) where T : class
        {
            T result = null;
            try
            {
                result = JsonConvert.DeserializeObject<T>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return result;
        }
    }
}
