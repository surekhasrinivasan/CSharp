using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaFunctionExample
{
    //// Program to demo Lambda Function example
    //class Program
    //{
    //    delegate int Square(int num);
    //    static void Main(string[] args)
    //    {
    //        Square GetSquare = x => x * x;
    //        int j = GetSquare(5);
    //        Console.WriteLine("Square: " + j);
    //    }
    //}

    // Program to demo Anonymous function Example
    class Program
    {
        public delegate void AnonymousFun();
        static void Main()
        {
            AnonymousFun fun = delegate ()
            {
                Console.WriteLine("This is anonymous function");
            };
            fun();
        }
    }
}
