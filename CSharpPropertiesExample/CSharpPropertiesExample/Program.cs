using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPropertiesExample
{
    // Program to demo Example for C# Properties 

    // C# Properites doesn't have storage location. 
    // C# Properites are extension of fields and accessed like fields. 
    // The Properties have accessors that are used to set, get or compute their values.
    public class Employee
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Name = "John Smith";
            Console.WriteLine("Employee Name: " + e1.Name);
        }
    }
}
