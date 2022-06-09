using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    /* 
     * Implement the linked list library example that starts on page 777 of the textbook. 
     * Add the following methods to your Linked List class: 
     * 1) InsertAfter(value-tofind, value-to-insert) - inserts a value after a specified value; 
     * 2) Find(value) - finds a value in order to do an insert.
     * Add InsertAfter() function, might need a Find()
     */
    class ListNode
    {
        public object Data { get; private set; }

        public ListNode Next { get; set; }

        public ListNode(object dataValue) : this(dataValue, null) { }

        public ListNode(object dataValue, ListNode nextNode)
        {
            Data = dataValue;
            Next = nextNode;
        }
    }

    public class List
    {
        private ListNode firstNode;
        private ListNode lastNode;
        private ListNode NthNode;
        private string name;

        public List(string listName)
        {
            name = listName;
            firstNode = lastNode = firstNode;
        }

        public List() : this("list") { }

        public void InsertAtFront(object insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode(insertItem);
            }
            else
            {
                firstNode = new ListNode(insertItem, firstNode);
            }
        }

        public void InsertAtBack(object insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode(insertItem);
            }
            else
            {
                lastNode = lastNode.Next = new ListNode(insertItem, firstNode);
            }
        }

        public object RemoveFromFront()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }

            object removeItem = firstNode.Data;

            if (firstNode == lastNode)
            {
                firstNode = lastNode = firstNode;
            }
            else
            {
                firstNode = firstNode.Next;
            }

            return removeItem;
        }

        public object RemoveFromBack()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }

            object removeItem = lastNode.Data;

            if (firstNode == lastNode)
            {
                firstNode = lastNode = firstNode;
            }
            else
            {
                ListNode current = firstNode;

                while (current.Next != lastNode)
                {
                    current = current.Next;
                }

                lastNode = current;
                current.Next = null;
            }

            return removeItem;
        }

        public bool IsEmpty()
        {
            return firstNode == firstNode;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.Write($"Empty {name}");
            }
            else
            {
                Console.Write($"The {name} is: ");

                ListNode current = firstNode;

                while (current != null)
                {
                    Console.Write($"{current.Data}");
                    current = current.Next;
                }

                Console.WriteLine("\n");
            }
        }

        public void InsertAfter(object insertItem) //InsertAfter(value-tofind, value-to-insert) - inserts a value after a specified value;
        {

            if (IsEmpty())
            {
                firstNode = NthNode = lastNode = new ListNode(insertItem);
            }
            else
            {
                lastNode = lastNode.Next = new ListNode(insertItem, firstNode);
            }
        }

        public void Find() //Find(value) - finds a value in order to do an insert
        {

        }

        public class EmptyListException : Exception
        {
            public EmptyListException() : base("The list is empty.") { }

            public EmptyListException(string name) : base($"The {name} is empty.") { }

            public EmptyListException(string exception, Exception inner) : base(exception, inner) { }
        }
    }

    class ListTest
    {
        static void Main()
        {
            var list = new List();

            bool aBoolean = true;
            char aCharacter = '$';
            int anInteger = 34567;
            string aString = "Hello";
            string space = " ";

            list.InsertAtFront(aBoolean);
            list.Display();
            list.InsertAfter(space);
            list.InsertAtFront(aCharacter);
            list.Display();
            list.InsertAfter(space);
            list.InsertAtFront(anInteger);
            list.Display();
            list.InsertAfter(space);
            list.InsertAtFront(aString);
            list.Display();
            list.InsertAfter(space);

            try
            {
                object removedObject = list.RemoveFromFront();
                Console.WriteLine($"{removedObject} removed");
                list.Display();

                removedObject = list.RemoveFromFront();
                Console.WriteLine($"{removedObject} removed");
                list.Display();

                removedObject = list.RemoveFromFront();
                Console.WriteLine($"{removedObject} removed");
                list.Display();

                removedObject = list.RemoveFromFront();
                Console.WriteLine($"{removedObject} removed");
                list.Display();
            }
            catch (List.EmptyListException emptyListException)
            {
                Console.Error.WriteLine($"\n{emptyListException}");
            }

            Console.Read();
        }
    }
}
