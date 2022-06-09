using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Map_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var map = new Dictionary<string, string>();

            // ... Add some keys and values.
            map.Add("cat", "orange");
            map.Add("dog", "brown");

            // ... Loop over the map.
            foreach (var pair in map)
            {
                string key = pair.Key;
                string value = pair.Value;
                Console.WriteLine(key + "/" + value);
            }

            // ... Get value at a known key.
            string result = map["cat"];
            Console.WriteLine(result);

            // ... Use TryGetValue to safely look up a value in the map.
            string mapValue;
            if (map.TryGetValue("dog", out mapValue))
            {
                Console.WriteLine(mapValue);
            }
        }
    }
}
