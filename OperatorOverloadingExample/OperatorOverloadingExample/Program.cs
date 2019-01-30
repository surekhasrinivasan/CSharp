using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingExample
{
    // Example Program to show Operator Overloading 
    class program
    {
        static void Main(string[] args)
        {

        }
    }

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
}
