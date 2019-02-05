using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name1
{
    class ClassA
    {
        public static void Display()
        {
            Console.WriteLine("Namespace1");
        }
    }
}
namespace name2
{
    class ClassA
    {
        public static void Display()
        {
            Console.WriteLine("Namespace2");
        }
    }
}
namespace NamespacesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            name1.ClassA.Display();
            name2.ClassA.Display();

        Console.Read();
        }
    }
}
