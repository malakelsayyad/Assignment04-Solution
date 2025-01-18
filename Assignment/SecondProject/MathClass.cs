using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.SecondProject
{
    public static class MathClass
    {
        public static double Add(double num1, double num2)
        {
            return num1+num2;
        }

        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;

        }

        public static double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
             
            }
            return num1 / num2;
        }
    }
}
