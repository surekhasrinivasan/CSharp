using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectOOPPrinciples
{
    // Demo program to show class, objects, OOP principles like Encapsulation, Inheritance and Polymorphism    
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car();
            car1.color = "Red";
            car1.manufacturer = "Toyota";

            Console.WriteLine("Car1 is " + car1.color + " in color and the make is " + car1.manufacturer);

            var saloonCar1 = new SaloonCar();
            saloonCar1.numberOfSeats = 5;

            Console.WriteLine("Car1 is " + car1.color + " in color, the make is " + car1.manufacturer + " and number of seats is " + saloonCar1.numberOfSeats);


        }
    }

    public class Car
    {
        public Car(){
        }

        public string color { get; set; }
        public string manufacturer { get; set; }
    }

    public class SaloonCar : Car
    {
        public SaloonCar()
        {
        }

        public int numberOfSeats { get; set; }
    }
}
