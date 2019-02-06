using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassExample
{
    // Sealed classes are used to restrict the users from inheriting the class. A class can be sealed by using the sealed keyword. ... However, 
    // a method can be sealed in the classes in which they have been inherited. If you want to declare a method as sealed, 
    // then it has to be declared as virtual in its base class. 

    // Program to show the implementation of Sealed class

    sealed class SealedClass
    {
        public int x;
        public int y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            SealedClass sc = new SealedClass();
            sc.x = 100;
            sc.y = 100;

            Console.WriteLine("X = {0}, y = {1}", sc.x, sc.y);

            Console.Read();
        }
    }
}
