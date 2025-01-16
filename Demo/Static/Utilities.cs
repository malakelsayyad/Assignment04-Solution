using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Static
{
    // Static [Helper]
    internal static class Utilities
    {
        // public int X { get; set; }
        // public int Y { get; set; }

        private static double pi;

        //public Utilities()
        //{
        //    pi = 3.14;
        //}

        static Utilities()
        {
            pi = 3.14;
        }

        // Static Method : Class member method
        public static double CmToInch(double cm )
        {
            return cm / 2.54;
        }

        public static double PI 
        { 
            get
            { 
                return pi; 
            }
        }
    }
}
