using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLinkedListExample2
{
    // simple c# program to implement Single Link List with operations AddItemStart, AddItemEnd, RemoveItemStart, RemoveItemEnd and DisplayAllItems
    class Program
    {
        public class Node
        {
            public object data;
            public Node next;
        }

        Node head;
        Node current;
        int counter = 0;

        public Program()
        {
            head = new Node();
            current = head;
        }

        static void Main(string[] args)
        {
        }
    }
}
