using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleForCsharpOutParameter
{
    //// Example Program for C# out parameter
    //class Program
    //{
    //    public void Show(out int val)
    //    {
    //        int square = 5;
    //        val = square;
    //        val *= val; // Manipulating value
    //    }

    //    static void Main(string[] args)
    //    {
    //        int val = 50;
    //        Program program = new Program(); // Creating object
    //        Console.WriteLine("Value before passing out variable " + val);
    //        program.Show(out val); // Passing out argument
    //        Console.WriteLine("Value after receiving the out variable " + val);
    //    }
    //}

    // Example - 2 example demonstrates that how a function can return multiple values.
    class Program
    {
        public void Show(out int a, out int b)// Out parameter
        {
            int square = 5;
            a = square;
            b = square;

            // Manipulating value
            a *= a;
            b *= b;
        }            

        static void Main(string[] args)
        {
            int val1 = 50, val2 = 100;
            Program program = new Program(); // Creating object
            Console.WriteLine("Value before passing \n val1 = " + val1 + "\n val2 = " + val2);
            program.Show(out val1, out val2); // Passing out argument
            Console.WriteLine("Value after passing \n val1 = " + val1 + "\n val2 = " + val2);
        }
    }
}
