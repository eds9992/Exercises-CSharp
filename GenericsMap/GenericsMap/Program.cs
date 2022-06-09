using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMap
{
    /*
     * Create a Map class that stores a collection of key/value pairs. 
     * The key/value pairs should be implemented using a Pair class that has the fields and properties First and Second. 
     * The Pair class and the Map class must be generic so that the keys can be of any type and the values can be of any type. 
     * The Map class should include methods for:
     * -adding a new key/value pair
     * -searching for a value by supplying the key 
     * -returning all the keys in a map 
     * -clearing the map in order to start over
     * -a size method that returns the number of key/value pairs in the map
     * 
     * Use the Map class in an application of your choosing. 
     * You can implement a word dictionary or a phone book or something else that functions like a dictionary. 
     */
    class Program
    {
        public class Pair<F, S>
        {
            public F First { get; set; }
            public S Second { get; set; }
            public Pair(F first, S second)
            {
                First = first;
                Second = second;
            }
        }

        class Map<F, S>
        {

            static void AddKeyValue(string name, int age) //changed from public
            {
                Map.Add("Bob", 23);
                Map.Add("Billy", 23);
                return (F, S);
            }
            public void SearchValue()
            {

            }
            public void ReturnKeys()
            {

            }
            public void ClearMap()
            {

            }
            public void Size()
            {

            }
        }

        static void Main(string[] args)
        {
            var map = new Dictionary<string, int>();
            Pair<String, int> p1 = new Pair<String, int>("Bob", 23);
            Console.WriteLine(p1.First + ": " + p1.Second);
            Pair<String, String> p2 = new Pair<String, String>("HTML", "Hypertext Markup Link");
            Console.WriteLine(p2.First + ": " + p2.Second);
            p1.Second += 1;
            Console.WriteLine(p1.First + ": " + p1.Second);
            Console.ReadLine();
        }
    }
}
