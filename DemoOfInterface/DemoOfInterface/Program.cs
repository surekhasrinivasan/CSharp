using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOfInterface
{
    // Program to showcase how to use interfaces

    // Defining the interface
    public interface Marks
    {
        // Declaring the interface methods
        void DisplayMarks();
        int Calculate();
    }
    public class Student : Marks
    {
        public int StudentID;
        public string StudentName;
        public int marks1, marks2;

        // Defining the interface methods
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
        // The main function 
        static void Main(string[] args)
        {
            Student student1 = new Student();

            student1.StudentID = 1;
            student1.StudentName = "John";
            student1.marks1 = 10;
            student1.marks2 = 20;
            student1.DisplayMarks();
            Console.WriteLine("The Total marks is " + student1.Calculate());

            Console.Read();
        }
    }
}
