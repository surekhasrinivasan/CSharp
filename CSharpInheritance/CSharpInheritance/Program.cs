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

// Man class
public class Man
{
    public Man(){
    }
    public bool moves { get; set; } 
    public string name { get; set; }
    public string color { get; set; }
}       

// Kart class
public class Kart
{
    public Kart(){
    }
    public bool moves { get; set; }
    public string manufacturer { get; set; }
    public string color { get; set; }
}

// Alien class 
public class Alien 
{
    public Alien(){
    }
    public bool moves { get; set; }
    public string planet { get; set; }
    public string color { get; set; }
}





