using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    /* The word polymorphism means having many forms. In object-oriented programming paradigm, 
     * polymorphism is often expressed as 'one interface, multiple functions'.
     * Polymorphism can be static or dynamic. In static polymorphism, the response to a function is 
     * determined at the compile time. In dynamic polymorphism, it is decided at run-time.
     * 
     * */
    // Program to show example for polymorphism 

    
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
        public void Display()
        {
            Console.WriteLine("This is the Person class");
        }
    }

    // Student class inherits the Person class
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
        public new void Display()
        {
            Console.WriteLine("This is the Student class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating objects of Person and Student class
            Person person = new Person();
            Student student = new Student();

            person.Display();
            student.Display();
            Console.Read();
        }
    }
}
