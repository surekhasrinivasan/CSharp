﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    // Delegate is a reference to the method. It works like function pointer in C and C++. 
    // But it is object oriented, secured and type-safe than function pointer. 

    // Program to demo Delegate Example
    class Program
    {
        static int number = 100;

        public static int add(int n)
        {
            number = number + n;
            return number;
        }

        static void Main(string[] args)
        {
        }
    }
}
