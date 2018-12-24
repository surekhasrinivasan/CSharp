using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class 
            var dozer = new BullDozer("Yellow", "Mini");
            //dozer.color = "Yellow";
            //dozer.size = "Mini";

            // Another object
            var dozer2 = new BullDozer("Red", "Large");

            //dozer2.color = "Red";
            //dozer2.size = "Large";
            

            //Console.WriteLine("Hello World"); 
            Console.WriteLine("Bulldozer is  " + dozer.color + " and its " + dozer.size + " size");
            Console.WriteLine("Bulldozer is  " + dozer2.color + " and its " + dozer2.size + " size");
        }        
    }

    // Class - blueprint 
    public class BullDozer
    {
        // Constructor 
        public BullDozer(string _color, string _size)
        {
            this.color = _color;
            this.size = _size;
        }
        
        // Properties 
        public string color { get; set; }
        public string size { get; set; }
    }
}
