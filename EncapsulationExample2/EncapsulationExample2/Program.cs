using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample2
{
    // C# has the facility to encapsulate its data members so that they are not exposed to other classes. You can then utilize getter and setter methods,
    // which can be used to get and set the data members accordingly. 

    // Example program to demonstrate Encapsulation

    class Student
    {
        // Encapsulating the ID property
        private int ID;

        public void SetID(int pID)
        {
            ID = pID;
        }

        public string getID()
        {
            return ID.ToString();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            string ID;

            // creating an object of the Student class
            Student student = new Student();
            student.SetID(1);

            ID = "The ID of the student is: " + student.getID();

            Console.WriteLine(ID);
            Console.Read();
        }
    }
}
