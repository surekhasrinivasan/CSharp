using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSingleLinkedList
{
    // C# program to implement Singly LinkedList traversal

    class SingleLinkedList
    {
        private int data;
        private SingleLinkedList next;

        public SingleLinkedList()
        {
            data = 0;
            next = null;
        }

        public SingleLinkedList(int value)
        {
            data = value;
            next = null;
        }

        public SingleLinkedList InsertNext(int value)
        {
            SingleLinkedList node = new SingleLinkedList(value);
            if(this.next == null)
            {
                node.next = null;
                this.next = node;
            }
            else
            {
                SingleLinkedList temp = this.next;
                node.next = temp;
                this.next = node;
            }
            return node;
        }
        public int DeleteNext()
        {
            if(next == null)         
                return 0;
            SingleLinkedList node = this.next;
            this.next = this.next.next;
            node = null;
            return 1;
        }

        public void Traverse(SingleLinkedList node)
        {
            if (node == null)
                node = this;
            Console.WriteLine("Traversing Singly Linked List: ");
            while(node != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList node1 = new SingleLinkedList(100);
            SingleLinkedList node2 = node1.InsertNext(200);
            SingleLinkedList node3 = node2.InsertNext(300);
            SingleLinkedList node4 = node3.InsertNext(400);
            SingleLinkedList node5 = node4.InsertNext(500);
            node1.Traverse(null);
            Console.WriteLine("Deleting from Linked List...");
            node3.DeleteNext();
            node2.Traverse(null);
            Console.ReadLine();            
        }
    }
}
