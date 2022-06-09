using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_Lists_Problems
{
    class Program
    {
        /*
         * n people, numbered n to 1
         * if M=0 and N=5, order of elimination is 12345
         * if M=1 and n=5, order of elimination is 2415
         */

        class Node
        {
            public int Data { get; set; }

            public Node Next { get; set; }

            public int Counter { get; set; }

            public Node(int element, int counter)
            {
                Data = element;
                Counter = counter;
                Next = null;
            }
        }

        class CircularLinkedList
        {
            Node first;
            Node last;

            public CircularLinkedList()
            {
                first = last = null;
            }

            protected void Insert(int element, int counter)
            {
                if (IsEmpty())
                {
                    first = last = new Node(element, counter);
                }
                else
                {
                    last.Next = last = new Node(element, counter);
                    last.Next = first;
                }
            }

            public int RemoveAt(int index)
            {
                int value = 0;
                Node current = first;
                do
                {
                    if (current.Counter == index)
                    {
                        value = current.Data;
                    }
                    current = current.Next;
                } while (current != first);
                return value;
            }

            public void AddMen(int n)
            {
                for (int i = 1; i <= n; i++)
                {
                    Insert(i * 2, i);
                }
            }

            public int Eliminate(int m)
            {
                int value = 0;
                Node current = first;
                Node nextNode;
                do
                {
                    nextNode = current.Next;
                    value = RemoveAt(m);

                    current = nextNode;

                } while (current != first);
                return value;
            }

            public bool IsEmpty()
            {
                return first == null;
            }

            public void Display()
            {
                Node current = first;
                do
                {
                    Console.WriteLine(current.Counter + " " + current.Data + " ");
                    current = current.Next;
                } while (current != first);
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
