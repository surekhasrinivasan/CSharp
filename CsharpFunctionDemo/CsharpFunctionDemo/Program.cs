using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFunctionDemo
{
    // C# function: Using no parameter and return type

    // A function that does not return any value specifies void 
    // type as a return type.

    //class Program
    //{
    //    // No return type
    //    public void Show() // no parameter
    //    {
    //        Console.WriteLine("This is no parameter function");
    //    }

    //    static void Main(string[] args)
    //    {
    //        Program program = new Program(); // Creating object
    //        program.Show(); // calling function
    //    }
    //}

    // C# function: Using parameter but no return type

    //class Program
    //{
    //    // No return type
    //    public void Show(string message) 
    //    {
    //        Console.WriteLine("Hello " + message);
    //    }

    //    static void Main(string[] args)
    //    {
    //        Program program = new Program(); // Creating object
    //        program.Show("Happy World!"); // calling function
    //    }
    //}

    // C# function: Using parameter and return type

    class Program
    {
        // function with return type (string in this case)
        public string Show(string message)
        {
            Console.Write("Inside Show function: ");
            return message;
        }

        static void Main(string[] args)
        {
            Program program = new Program(); // Creating object
            string message = program.Show("Happy World!"); // calling function
            Console.WriteLine("Hello " + message);
        }
    }
}
