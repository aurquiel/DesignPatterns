using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Prototype
{
    public interface IDeepClonable<T> where T : class
    {
        public T DeepCopy();

        public T DeepCopySerilization<T>(T item)
        {
            string jsonString = JsonSerializer.Serialize<T>(item);
            return JsonSerializer.Deserialize<T>(jsonString);
        }
    }
}
