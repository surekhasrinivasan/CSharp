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

// GeneralObject Class created to bring in common properties of Man, Kart and Alien
public class GeneralObject
{
    public GeneralObject(){
    }
    public bool moves { get; set; }
    public string color { get; set; }
}

// Man class inheriting GeneralObject class
public class Man : GeneralObject
{
    public Man(){
    }
    public string name { get; set; }    
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





