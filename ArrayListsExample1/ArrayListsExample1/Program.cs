using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListsExample1
{
    // The following Program is used to show the way to use array lists
    class Program
    {
        static void Main(string[] args)
        {
            // Defining the Arraylist
            ArrayList ar = new ArrayList();

            // Adding elements to the array list
            ar.Add(1);
            ar.Add(2);
            ar.Add(3);

            // Adding string elements to the array list
            ar.Add("Hello");
            ar.Add("World");
            ar.Add("Again");

            // Displaying the elements
            Console.WriteLine("The first element of the array is " + ar[0]);
            Console.WriteLine("The second element of the array is " + ar[1]);
            Console.WriteLine("The third element of the array is " + ar[2]);
            Console.WriteLine("The fourth element of the array is " + ar[3]);
            Console.WriteLine("The fifth element of the array is " + ar[4]);
            Console.WriteLine("The sixth element of the array is " + ar[5]);
            Console.Read();
        }
    }
}
