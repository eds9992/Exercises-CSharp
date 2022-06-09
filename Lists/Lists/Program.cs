using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static int countItems(List<string> aList, string item)
        {
            int counter = 0;
            foreach (string element in aList)
            {
                if (element == item)
                {
                    ++counter;
                }
            }
            return counter;
        }

        static string display(List<string> aList)
        {
            string items = " ";
            foreach (string item in aList)
            {
                items += item + " ";
            }

            return items;
        }

        static List<string> removeAll(List<string> aList, string item)
        {
            while (aList.Contains(item))
            {
                aList.Remove(item);
            }
            return aList;
        }

        static void Main(string[] args)
        {
            var names = new List<string>();
            names.Add("Cynthia");
            names.Add("Raymond");
            names.Add("Jonathan");
            names.Add("Danny");
            names.Add("Raymond");
            names.Add("Mayo");
            names.Add("Raymond");
            string name = "Raymond";
            int count = countItems(names, name);
            Console.WriteLine("Found " + name + " " + count + " times");
            string listItems = display(names);
            Console.WriteLine(display(names));

            Console.ReadLine();
        }
    }
}
