using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEncapsulation
{
    // Encapsulation is sometimes called Data hiding
    // Example for encapsulation
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new FactoryWorker();
            var result = worker.addNumbers(5, 3);

            Console.WriteLine(result.ToString());
        }
    }

    public class FactoryWorker
    {
        public FactoryWorker(){
        }

        // Method to add numbers
        // Changes made inside the method but does not affect the output
        public int addNumbers(int num1, int num2)
        {
            var result = num1 + num2;

            result = result + 100;
            result = result - 100;

            return result;
        } 
    }
}
