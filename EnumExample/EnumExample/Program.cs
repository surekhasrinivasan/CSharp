﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    //// Program to demo a simple Enum Example
    //class Program
    //{
    //    public enum Season { WINTER, SPRING, SUMMER, FALL }


    //    static void Main(string[] args)
    //    {
    //        int x = (int)Season.WINTER;
    //        int y = (int)Season.SUMMER;
    //        Console.WriteLine("WINTER = {0}", x);
    //        Console.WriteLine("SUMMER = {0}", y);
    //    }
    //}

    // Program to demo Enum Example changing start index
    class Program
    {
        public enum Season { WINTER = 10, SPRING, SUMMER, FALL }

        static void Main(string[] args)
        {
            int x = (int)Season.WINTER;
            int y = (int)Season.SUMMER;
            Console.WriteLine("WINTER = {0}", x);
            Console.WriteLine("SUMMER = {0}", y);
        }
    }
}
