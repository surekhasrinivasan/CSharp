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

            var saloonCar = new SaloonCar();
            saloonCar.numberOfSeats = 5;

            Console.WriteLine("SaloonCar is " + car1.color + " in color, the make is " + car1.manufacturer + " and number of seats is " + saloonCar.numberOfSeats);

            var saloonCar1 = new SaloonCar(2);
            Console.WriteLine("saloonCar1 has " + saloonCar1.numberOfSeats + " seats");

            var saloonCar2 = new SaloonCar(3, "Nissan");
            Console.WriteLine("saloonCar2 has " + saloonCar2.numberOfSeats + " seats and its manufacturer is " + saloonCar2.manufacturer);

            var saloonCar3 = new SaloonCar(4, "Ford", "purple");
            Console.WriteLine("saloonCar3 has " + saloonCar3.numberOfSeats + " seats, its manufacturer is " + saloonCar3.manufacturer + " and color is " + saloonCar3.color);
        }
    }

    public class Car
    {
        public Car(){
        }

        public string color { get; set; }
        public string manufacturer { get; set; }
    }

    // Inheritance
    public class SaloonCar : Car
    {
        // Default constructor
        public SaloonCar()
        {
        }

        public int numberOfSeats { get; set; }

        // Polymorphism

        // Parameterized constructor
        public SaloonCar(int numberOfSeats)
        {
            this.numberOfSeats = numberOfSeats;

        }
        
        public SaloonCar(int numberOfSeats, string manufacturer)
        {
            this.numberOfSeats = numberOfSeats;
            this.manufacturer = manufacturer;
        }

        public SaloonCar(int numberOfSeats, string manufacturer, string color)
        {
            this.numberOfSeats = numberOfSeats;
            this.manufacturer = manufacturer;
            this.color = color;
        }
    }
}