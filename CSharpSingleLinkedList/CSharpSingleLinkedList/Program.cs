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
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
