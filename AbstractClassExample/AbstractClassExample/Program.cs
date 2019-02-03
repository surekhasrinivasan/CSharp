﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    // Example to show Abstract class and Abstract method

    // Abstract class cannot be instantiated. In an abstract class there should be an abstract property or an abstract method. 

    abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void Work();        
    }

    class Student : Person
    {
        public override void Work()
        {
            Console.WriteLine("It studies...");
        }
    }

    class Employee : Person
    {
        public double Salary { get; set; }
        public string Designation { get; set; }

        public override void Work()
        {
            Console.WriteLine("It earns...");
        }
    }

    class Manager  : Employee
    {
        public sealed override void Work()
        {
            Console.WriteLine("It manages a team...");
        }

    }

    class BranchManager : Manager
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Student();
            p1.Work();
            p1 = new Employee();
            p1.Work();
            p1 = new BranchManager();
            p1.Work();
        }
    }
}
