using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinSearch
{
    class Program
    {
        /*
         * 1. Modify the binary search function so that it counts the 
         * number of steps it takes to find a searched for value.
         * 2. Add code to the selection sort function so that the intermediate states
         * of the array are displayed while it is being sorted.
         * Example: 3 1 2 5 4 => 1 3 2 5 4 => 1 2 3 5 4 => 1 2 3 4 5
         */

        public static int count = 0;

        public static int binarySearch(int [] values, int value)
        {
            int low = 0;
            int high = values.Length - 1;
            int mid = (low + high + 1) / 2;
            //int count = 0;
            do
            {
                if (value == values[mid])
                {
                    return mid;
                    count = ++count;
                }
                else if (value < values[mid])
                {
                    high = mid - 1;
                    count = ++count;
                }
                else
                {
                    low = mid + 1;
                    count = ++count;
                }
                mid = (low + high + 1) / 2;
                //count = ++count;
            } while (low <= high);
            Console.WriteLine("Steps taken to search: " + count);
            return -1;
        }

        public static void swap(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }

        public static void selectionSort(int [] values)
        {
            for (int i = 0; i < values.Length - 1; ++i)
            {
                int smallest = i;
                string a = "";
                for (int index = i + 1; index < values.Length; ++index)
                {
                    if(values[index] < values[smallest])
                    {
                        smallest = index;
                    }
                }
                swap(ref values[i], ref values[smallest]);
                for (int index = 0; index < 10; ++index)
                {
                    a = a + values[index];
                }
                Console.WriteLine("\n" + a);
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random randomNumbers = new Random();
            for (int i = 0; i < 10; ++i)
            {
                numbers[i] = randomNumbers.Next(1, 10);
                Console.Write(numbers[i] + " ");
            }
            selectionSort(numbers);
            Console.Write("\n" + "Array after sorting: ");
            for (int i = 0; i < 10; ++i)
            {
                Console.Write(numbers[i] + " ");
            }
            int searchValue;
            Console.Write("\n" + "Enter a value to search for: ");
            searchValue = int.Parse(Console.ReadLine());
            int found = binarySearch(numbers, searchValue);
            if (found > -1)
            {
                Console.WriteLine("Found " + searchValue + " at position " + found);
            }
            else
            {
                Console.WriteLine("Did not find " + searchValue + " in array.");
            }
            Console.WriteLine("Steps taken to search: " + count);
            Console.ReadLine();
        }
    }
}
