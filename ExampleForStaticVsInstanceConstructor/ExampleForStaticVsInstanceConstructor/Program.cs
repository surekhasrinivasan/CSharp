using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleForStaticVsInstanceConstructor
{
    /* Static constructor is a special constructor that gets called before the first object of the 
     * class is created. It is used to initialize any static data, or to perform a particular action 
     * that needs performed once only.
     * 
     * Instance constructor is used to initialize instance data. Instance constructor is called 
     * every time when object of class is created.
     */
    
    class RandomNumberClass
    {
        private static Random RandomKey; // Private static field
        static RandomNumberClass() // Static constructor
        {
            RandomKey = new Random(); // Initialize RandomKey
        }
        public int GetRandomNumber()
        {
            return RandomKey.Next();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
