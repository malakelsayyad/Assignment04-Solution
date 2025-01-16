using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    // Concrete class
    internal class Rectangle : Shape /*: implement and inherit from shape */
    {

        public override double GetArea()
        {
            return Dim01 * Dim02;
        }

        public override double Perimeter
        {
            get
            {
                return (Dim01 + Dim02) * 2;
            }
        }
    }
}
