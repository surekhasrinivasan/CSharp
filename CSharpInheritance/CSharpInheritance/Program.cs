using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritance
{
    // Program to show Inheritance and Hierarchy
    class Program
    {
        static void Main(string[] args)
        {
            var man = new Man();
            var kart = new Kart();
            var alien = new Alien();         
        }
    }
}
// Tree Hierarchy of Inheritance - Man and Woman class inherits Human which inherits GeneralObject
public class GeneralObject
{
    public GeneralObject(){
    }
    public bool moves { get; set; }
    public string color { get; set; }
}
    // Human class inherits GeneralObject class
    public class Human : GeneralObject
    {
        public Human(){
        }
        public string name { get; set; }
    }

        // Man class inheriting Human class
        public class Man : Human
        {
            public Man(){
            }           
        }

        // woman class inheriting Human class
        public class Woman : Human
        {
            public Woman(){
            }    
        }

// Kart class inheriting GeneralObject Class
public class Kart : GeneralObject
{
    public Kart()
    {
    }
    public string manufacturer { get; set; }
}

// Alien class inheriting GeneralObject class
public class Alien : GeneralObject
{
    public Alien(){
    }
    public string planet { get; set; }
}





