using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureExample
{
    // Program to demo Structure

    struct Student
    {
        public int ID;
        public string Name;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an object of the Student class
            Student student;

            // Defining the properties of the structure
            student.ID = 1;
            student.Name = "John";

            // Displaying the properties of the structure
            Console.WriteLine(student.ID);
            Console.WriteLine(student.Name);
            Console.Read();
        }
    }
}
