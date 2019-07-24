using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleForCsharpOutParameter
{
    // Example Program for C# out parameter
    class Program
    {
        public void Show(out int val)
        {
            int square = 5;
            val = square;
            val *= val; // Manipulating value
        }

        static void Main(string[] args)
        {
            int val = 50;
            Program program = new Program(); // Creating object
            Console.WriteLine("Value before passing out variable " + val);
            program.Show(out val); // Passing out argument
            Console.WriteLine("Value after receiving the out variable " + val);
        }
    }
}
