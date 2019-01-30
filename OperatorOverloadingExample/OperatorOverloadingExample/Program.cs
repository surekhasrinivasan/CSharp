using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingExample
{
    // Example Program to show Operator Overloading

    class Rect
    {
        public int length;
        public int breadth;
        public static Rect operator +(Rect b, Rect c)
        {
            Rect rec = new Rect();
            rec.length = b.length + c.length;
            rec.breadth = b.breadth + c.breadth;

            return rec;
        }
    }
     
    class program
    {
        static void Main(string[] args)
        {
            Rect rec1, rec2, rec3;

            rec1 = new Rect();
            rec1.length = 3;
            rec1.breadth = 3;

            rec2 = new Rect();
            rec2.length = 7;
            rec2.breadth = 7;

            rec3 = new Rect();
            rec3 = rec1 + rec2;

            Console.WriteLine("The length of the Rectangle 3 is: " + rec3.length);
            Console.WriteLine("The breadth of the Rectangle 3 is: " + rec3.breadth);
            Console.Read();
        }
    }    
}