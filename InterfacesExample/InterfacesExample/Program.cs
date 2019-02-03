using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    /* An interface is defined as a syntactical contract that all the classes inheriting the interface should follow. 
     * The interface defines the 'what' part of the syntactical contract and 
     * the deriving classes define the 'how' part of the syntactical contract. 
     * */

    // A simple interface declaration
    interface IStudent
    {
        // Only the function is part of the interface
        void Display();
    }

    class Student : IStudent
    {
        // Encapsulating the ID property
        private int ID;

        public void setID(int pID)
        {
            ID = pID;
        }

        public string getID()
        {
            return ID.ToString();
        }

        // Student class defines how the Display() function should be 
        public void Display()
        {
            string ID = "The ID of the student is : " + this.ID;

            // Displaying the student ID to the console
            Console.WriteLine(ID);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // creating an object of the Student class
            Student student = new Student();
            student.setID(101);
            student.Display();
            Console.Read();
        }
    }
}
