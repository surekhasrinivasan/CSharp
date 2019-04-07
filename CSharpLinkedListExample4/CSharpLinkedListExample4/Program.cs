using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLinkedListExample4
{
    // Program to find node in Linked List
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Linked List
            LinkedList<string> list = new LinkedList<string>();

            // Add elements to the linked list
            list.AddLast("A");
            list.AddLast("B");
            list.AddLast("C");

            // Insert a node before the second node (after the first node)
            LinkedListNode<string> node = list.Find("A");
            list.AddAfter(node, "Inserted Node");

            // loop through the linked list
            Console.WriteLine("Elements in the linked list: ");
            foreach(var value in list)
            {
                Console.WriteLine(value);
            }
        }
    }
}
