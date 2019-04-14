using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenericHashSetExample1
{
    /* Program creates two HashSet<T> objects and populates them with even and odd numbers. 
     * Then a third HashSet<T> object is created from the set that contains the even numbers. 
     * Using UnionWith method it adds the odd number set to the third set. 
     */

    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> evenNumbers = new HashSet<int>();
            HashSet<int> oddNumbers = new HashSet<int>();

            for(int i = 0; i < 5; i++)
            {
                // Populate numbers with just even numbers 
                evenNumbers.Add(i * 2);

                // Populate numbers with just odd numbers 
                oddNumbers.Add((i * 2) + 1);
            }
            Console.Write("evenNumbers contains {0} elements: ", evenNumbers.Count);
            DisplaySet(evenNumbers);
            
            Console.Write("oddNumbers contains {0} elements: ", oddNumbers.Count);
            DisplaySet(oddNumbers);            
        }

        private static void DisplaySet(HashSet<int> set)
        {
            Console.Write("{");
            foreach(int i in set)
            {
                Console.Write("{0} ", i);
            }
            Console.Write("}");
            Console.WriteLine();
        }
    }
}
