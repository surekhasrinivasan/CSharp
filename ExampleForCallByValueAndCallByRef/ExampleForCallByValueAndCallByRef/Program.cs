using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleForCallByValueAndCallByRef
{
    // Program to demo Call By Value
    class Program
    {
        // User defined function
        public void Show(int val)
        {
            val *= val; // Manipulating value
            Console.WriteLine("Value inside the show function: " + val); // No return statement
        }

        static void Main(string[] args)
        {
            int val = 50;
            Program program = new Program();
            Console.WriteLine("Value before calling the function " + val);
            program.Show(val); // Calling Function by passing value
            Console.WriteLine("Value after caling the function " + val);
        }
    }
}
