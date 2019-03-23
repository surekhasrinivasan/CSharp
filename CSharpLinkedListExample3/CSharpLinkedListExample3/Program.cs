﻿using System;
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
            Node head = null;
            LinkedList.Append(ref head, 15);
            LinkedList.Append(ref head, 37);
            LinkedList.Append(ref head, 83);
            LinkedList.Append(ref head, 56);

            Console.WriteLine("Linked List: ");
            LinkedList.Print(head);
            Console.WriteLine();

            LinkedList.Reverse(ref head);

            Console.WriteLine();
            Console.WriteLine("Reversed Linked List: ");
            LinkedList.Print(head);

            Console.WriteLine();
             
            Console.WriteLine("Reverse of Reversed Linked List: ");

            LinkedList.ReverseUsingRecursion(head);
            head = LinkedList.newHead;
            LinkedList.PrintRecursive(head);
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

            public static void Print(Node head)
            {
                if (head == null) return;

                Node current = head;
                do
                {
                    Console.Write("{0} ", current.Data);
                    current = current.next;
                } while (current != null);
            }

            public static void PrintRecursive(Node head)
            {
                if(head == null)
                {
                    Console.WriteLine();
                    return;
                }

                Console.Write("{0} ", head.Data);
                PrintRecursive(head.next);
            }

            public static void Reverse(ref Node head)
            {
                if (head == null) return;

                Node prev = null, current = head, next = null;

                while (current.next != null)
                {
                    next = current.next;
                    current.next = prev;
                    prev = current;
                    current = next;
                }

                current.next = prev;
                head = current;
            }

            public static Node newHead;

            public static void ReverseUsingRecursion(Node head)
            {
                if (head == null) return;

                if (head.next == null)
                {
                    newHead = head;
                    return;
                }
                ReverseUsingRecursion(head.next);
                head.next.next = head;
                head.next = null;
            }
        }
    }
}
