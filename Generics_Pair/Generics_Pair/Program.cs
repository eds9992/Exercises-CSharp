using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Pair
{
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

        static void Main(string[] args)
        {
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
