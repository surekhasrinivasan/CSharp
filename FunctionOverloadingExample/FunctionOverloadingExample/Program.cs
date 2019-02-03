using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverloadingExample
{
    // Program to demo Function overloading
    class Program
    {
        // Add function with integers
        static int Add(int i, int j)
        {
            return i + j;
        }

        // Add function with strings
        static string Add(string i, string j)
        {
            return i + j;
        }

        // Add function with double values
        static double Add(double i, double j)
        {
            return i + j;
        }

        static void Main(string[] args)
        {
            int a = 1, b = 2;
            string c = "Hello";
            string d = "World";
            double e = 1.2222, f = 2.3333;

            // Calling the Add function of integers 
            Console.WriteLine(" " + Add(a,b));

            // Calling the Add function of strings 
            Console.WriteLine(" " + Add(c,d));

            // Calling the Add function of double 
            Console.WriteLine(" " + Add(e, f));

            Console.Read();
        }
    }
}
