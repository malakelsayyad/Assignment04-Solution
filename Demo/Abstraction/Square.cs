using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    internal class Square : Shape
    {
        public override double Perimeter 
        {
            get 
            {
                return 4 * Dim01;
            }
        }

        public override double GetArea()
        {
            return Dim01*Dim01;
        }
    }
}
