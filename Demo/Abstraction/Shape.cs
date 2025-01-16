using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    // Abstract Class : Partial class [Not fully implemented class]
    // Conctrete Class : Fully implemented class
    internal abstract class Shape
    {
        public double Dim01 { get; set; }
        public double Dim02 { get; set; }

        // Abstract method : like virtual method without implementation
        public abstract double GetArea();

        // Make this method abstract

        // Abstract property : : like virtual property without implementation
        public abstract double Perimeter { get; }

        public void Print()
        {
            Console.WriteLine("I'm a shape");
        }
        
    }
}
