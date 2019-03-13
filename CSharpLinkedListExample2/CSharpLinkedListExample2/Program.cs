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

        public void AddStart(object data)
        {
            Node newnode = new Node();
            newnode.next = head.next;
            newnode.data = data;
            head.next = newnode;
            counter++;
        }

        public void AddEnd(object data)
        {
            Node newnode = new Node();
            newnode.data = data;
            current.next = newnode;
            current = newnode;
            counter++;
        }

        static void Main(string[] args)
        {
        }
    }
}
