using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPolymorphism
{
    class Program
    {
        // Example for Polymorphism
        static void Main(string[] args)
        {
            var worker = new FactoryWorker();
            worker.Count(5);
            worker.Count(6);
            worker.Count(4.5f);
        }
    }

    public class FactoryWorker
    {
        public FactoryWorker()
        {
        }

        public void Count(int number)
        {
            if (Total == null)
                Total = 0;

            // convert number to float
            Total = Total + Convert.ToSingle(number);

            Console.WriteLine(Total.ToString());
        }

        // Another method with same name with different type of variable
        // this method is called only whenever worker.Count() in main method is passed with a float 
        public void Count(float number)
        {
            Total = Total + number;
            Console.WriteLine(Total.ToString());
        }

        // Class variable
        public float Total { get; set; }
    }
}