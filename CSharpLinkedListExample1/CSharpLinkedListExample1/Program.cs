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

            foreach(var element in l)
            {
                Console.WriteLine(element);
            }
        }
    }
}
