using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.FirstProject
{
    internal class Point3D : IComparable<Point3D>,ICloneable
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y ,double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
       
        public Point3D() : this(0,0,0)
        {
            
        }

        
        public int CompareTo(Point3D point3D )
        {
            if (point3D is null) 
                return 1;
            int result = X.CompareTo(point3D.X);
            if (result == 0)
            {
                
                result = Y.CompareTo(point3D.Y);
            }
            return result;
        }

        public static bool operator ==(Point3D p1, Point3D p2)
        { 
           if (p1 is not null && p2 is not null)
                return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
           return false;
        }
        public static bool operator !=(Point3D p1, Point3D p2)
        {
            if (p1 is not null && p2 is not null)
                return p1.X != p2.X || p1.Y != p2.Y || p1.Z != p2.Z;
            return false;
        }

        public override string ToString()
        {
            return $"({X},{Y},{Z})";
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
