using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEncapsulation
{
    // Example for encapsulation
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new FactoryWorker();
            var result = worker.addNumbers(5, 3);
            Console.WriteLine(result);
        }
    }

    public class FactoryWorker
    {
        public FactoryWorker(){
        }

        // Method to add numbers 
        public int addNumbers(int num1, int num2)
        {
            var result = num1 + num2;
            return result;
        } 
    }
}
