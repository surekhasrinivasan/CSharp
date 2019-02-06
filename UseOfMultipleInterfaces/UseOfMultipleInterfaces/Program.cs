using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseOfMultipleInterfaces
{
    // Program to demonstrate use of multiple interfaces by a class
         
    public interface Marks
    {
        // Declaring the interface methods
        void DisplayMarks();
        int Calculate();
    }
 
    public interface Location
    {
        // Declaring the interface methods
        void InputCity(string city);
        void DisplayCity();
    }

    public class Student : Marks, Location
    {
        public int StudentID;
        public string StudentName;
        public int marks1, marks2;
        private string city;

        // Defining the interface methods 
        public void InputCity(string pcity)
        {
            city = pcity;
        }

        public void DisplayCity()
        {
            Console.WriteLine("City is " + city);
        }

        public void DisplayMarks()
        {
            Console.WriteLine("The marks of subject 1 is " + marks1);
            Console.WriteLine("The marks of subject 2 is " + marks2);
        }

        public int Calculate()
        {
            return (marks1 + marks2);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();

            student1.StudentID = 101;
            student1.StudentName = "Smith";
            student1.marks1 = 20;
            student1.marks2 = 25;
            student1.DisplayMarks();
            Console.WriteLine("The total marks is " + student1.Calculate());

            student1.InputCity("Chicago");
            student1.DisplayCity();

            Console.Read();
        }
    }
}
