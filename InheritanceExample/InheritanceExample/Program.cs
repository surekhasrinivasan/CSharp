using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    // Example to demonstrate Inheritance in CSharp

    class Person
    {
        private int ID;
        public void setID(int pID)
        {
            ID = pID;
        }

        public string getID()
        {
            return ID.ToString();
        } 
    }

    // Student class inherits the Person Class
    class Student : Person
    {
        private string Name;

        public void setName(string pName)
        {
            Name = pName;
        }

        public string getName()
        {
            return Name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating Object of the Student Class
            Student student = new Student();
            student.setID(1);
            student.setName("John");

            Console.WriteLine("The Student Name is {0}, and his ID is {1}", student.getName(), student.getID());
            Console.Read();
        }
    }
}
