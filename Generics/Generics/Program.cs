using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        /*static int square(int n)
        {
            return n * n;
        }

        static double square(double n)
        {
            return n * n;
        }

        static T square<T>(T number)
        {
            return number * number;
        }*/

        static void displayArray<T>(T[] arr)
        {
            foreach (var num in arr)
            {
                Console.Write(num + " ");
                Console.WriteLine();
            }
        }

        public class Stack<T>
        {
            private int top;
            private T[] elements;
            private int stackSize = 10;

            public Stack()
            {
                elements = new T[stackSize];
                top = -1;
            }

            public void push(T value)
            {
                ++top;
                elements[top] = value;
            }

            public T pop()
            {
                --top;
                return elements[top + 1];
            }

            public T peek()
            {
                return elements[top];
            }
        }

        static void Main(string[] args)
        {
            Stack<int> nums = new Stack<int>();
            nums.push(1);
            Console.Write(nums.peek());
            nums.push(2);
            Console.Write(nums.peek());
            nums.pop();
            Console.Write(nums.peek());
            Stack<string> names = new Stack<string>();
            names.push("Jane");
            names.push("John");
            Console.Write(names.peek());
            names.pop();
            Console.Write(names.peek());
            /*int[] num = { 1, 2, 3, 4, 5 };
            displayArray(num);
            double[] dnum = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            displayArray(dnum);
            string[] names = { "Jane", "Bob", "Liz", "Sara" };
            displayArray(names);
            int num = 2;
            Console.WriteLine(square(num));
            double dnum = 2.2;
            Console.WriteLine(square(dnum));*/
            Console.ReadLine();
        }
    }
}
