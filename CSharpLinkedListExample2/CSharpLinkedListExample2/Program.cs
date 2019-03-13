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
        
        public void RemoveStart()
        {
            if(counter > 0)
            {
                head.next = head.next.next;
                counter--;
            }
            else
            {
                Console.WriteLine("No elements exist in this linked list);
            }

        }

        public void RemoveEnd()
        {
            if(counter > 0)
            {
                Node prevNode = new Node();
                Node cur = head;
                while(cur.next != null)
                {
                    prevNode = cur;
                    cur = cur.next;
                }
                prevNode.next = null;
            }
            else
            {
                Console.WriteLine("No elements exist in this linked list");
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
