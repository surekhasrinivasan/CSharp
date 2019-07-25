using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpListExample
{
    // Program to demo Csharp List Example
    class Program
    {
        static void Main(string[] args)
        {
            //// create a list of strings

            //var names = new List<string>();
            //names.Add("John Smith");
            //names.Add("Peter");
            //names.Add("Sam");
            //names.Add("George");

            // Iterate list element using foreach loop
            //foreach(var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            // Create a list of strings using collection initializer
            var names = new List<string>() { "Sam", "Tom", "Swa", "Rob" };

            // iterate through the list. 
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
