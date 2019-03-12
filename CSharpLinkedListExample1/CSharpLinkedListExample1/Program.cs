using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLinkedListExample1
{
    // Example 1 Program for linked list 
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> l = new LinkedList<string>();

            l.AddLast("One");
            l.AddLast("Two");
            l.AddLast("Three");

            foreach (var element in l)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            // Example 2 - A linked-list is a collection type that on the surface is very similar to the List<T> type, 
            // but the big difference is how the data is stored internally

            LinkedList<string> months = new LinkedList<string>();

            months.AddLast("March");
            months.AddFirst("January");

            var march = months.Find("March");

            months.AddBefore(march, "February");
            months.AddAfter(march, "April");

            foreach (var month in months)
            {
                Console.WriteLine(month);
            }
            Console.WriteLine();

            // Example 3 - illustrate the LinkedList<T> class properties 

            // Created LinkedList of string
            LinkedList<string> myList = new LinkedList<string>();

            // Adding Nodes in the LinkedList
            myList.AddLast("GeeksforGeeks");
            myList.AddLast("GFG");
            myList.AddLast("Data structures");
            myList.AddLast("Noida");

            // Count Property
            // To get the first Node of the LinkedList
            if(myList.Count > 0)
            {
                Console.WriteLine(myList.First.Value);
            }
            else
            {
                Console.WriteLine("LinkedList is Empty");
            }            

            // Last Property
            // To get the last Node of the LinkedList
            if(myList.Count > 0)
            {
                Console.WriteLine(myList.Last.Value);
            }
            else
            {
                Console.WriteLine("LinkedList is Empty");
            }
            Console.WriteLine();
        }
    }
}
