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

            Total = Total + number;
            Console.WriteLine(Total.ToString());
        }

        // Class variable
        public int Total { get; set; }
    }
}