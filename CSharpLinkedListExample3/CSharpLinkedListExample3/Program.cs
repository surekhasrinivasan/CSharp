using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLinkedListExample3
{
    // program to print a singly linked list backwards using recursion in C#

    class Program
    {
        static void Main(string[] args)
        {
        }

        public class Node
        {
            public int Data = 0;
            public Node next = null;
        }

        public static class LinkedList
        {
            public static void Append(ref Node head, int data)
            {
                if (head != null)
                {
                    Node current = head;
                    while(current.next != null)
                    {
                        current = current.next;
                    }
                    current.next = new Node();
                    current.next.Data = data;
                }
                else
                {
                    head = new Node();
                    head.Data = data;
                }
            }
        }
    }
}
