using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Operator_Overloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }

        // Operator Overloading
        // +
        // Must be static and public
        
        // Binary : + - / %
        public static Complex operator +( Complex left , Complex right)
        {
            return new Complex()
            {
                Real = (left?.Real ?? 0 )+ (right?.Real ?? 0) ,
                Imaginary = (left?.Imaginary ?? 0)+ (right?.Imaginary ?? 0)
            };
        }

        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0) ,
                Imaginary = (left?.Imaginary ?? 0) - (right?.Imaginary ?? 0)
            };
        }
        // Operator overloading 
        // ++ --
        // Static - Public method

        public static Complex operator ++(Complex complex)
        { 
          if(complex is not null)
             { 
                complex.Real++;
                return complex;
             }
            return new Complex();
 
        } 
        public static Complex operator --(Complex complex)
        { 
          if(complex is not null)
             { 
                complex.Real--;
                return complex;
             }
            return new Complex();
 
        }

        // Comparision operators : > < >= <= != ==
        // return type must be boolean

        public static bool operator >(Complex left , Complex right)
        { 
          if (left.Real>right.Real)
                return left.Imaginary > right.Imaginary;

          return left.Real > right.Real;
        }

        public static bool operator <(Complex left, Complex right)
        {
            if (left.Real < right.Real)
                return left.Imaginary <right.Imaginary;

            return left.Real < right.Real;
        }

        public static bool operator >=(Complex left, Complex right)
        {
            if (left.Real == right.Real)
                return left.Imaginary >= right.Imaginary;

            return left.Real >= right.Real;
        }

        public static bool operator <=(Complex left, Complex right)
        {
            if (left.Real == right.Real)
                return left.Imaginary <= right.Imaginary;

            return left.Real <= right.Real;
        }

        public static bool operator ==(Complex left, Complex right)
        {
            return left.Real== right.Real && left.Imaginary==right.Imaginary;
        } 
        public static bool operator !=(Complex left, Complex right)
        {
            return left.Real!= right.Real || left.Imaginary!=right.Imaginary;
        }

        // User Defined Casting operator
        // Complex ---> string

        // implicit - explicit
        public static  explicit operator string(Complex complex)
            {
              return complex.ToString();
            }

        public static explicit operator int(Complex complex)
        {
            return complex.Real;
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary} i";
        }


    }
}
