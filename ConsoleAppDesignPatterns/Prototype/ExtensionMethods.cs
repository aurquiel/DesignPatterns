using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Prototype
{
    public static class ExtensionMethods
    {
        public static T DeepCopySerilization<T>(this T item) where T : class
        {
            string jsonString = JsonSerializer.Serialize<T>(item);
            return JsonSerializer.Deserialize<T>(jsonString);
        }
    }
}
