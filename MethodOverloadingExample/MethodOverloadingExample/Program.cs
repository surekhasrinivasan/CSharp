using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingExample
{
    // Example program to show method overloading 

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void Work()
        {
            Console.WriteLine("It works....");
        }
    }

    class Employee : Person
    {
        public double Salary { get; set; }
        public string Designation { get; set; }
        public void Work()
        {
            Console.WriteLine("It earns....");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Employee();
            p1.Work();
        }
    }
}
