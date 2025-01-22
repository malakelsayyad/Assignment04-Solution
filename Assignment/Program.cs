using Assignment.FirstProject;
using Assignment.SecondProject;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Project

            // Point3D P = new Point3D(10, 10, 10);
            // Console.WriteLine(P.ToString());


            //double x1, y1, z1;
            //double x2, y2, z2;
            //Console.WriteLine("Enter coordinates for Point P1:");
            //Console.Write("Enter X: ");
            //while (!double.TryParse(Console.ReadLine(), out x1))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number for X.");
            //    Console.Write("Enter X: ");
            //}

            //Console.Write("Enter Y: ");
            //while (!double.TryParse(Console.ReadLine(), out y1))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number for Y.");
            //    Console.Write("Enter Y: ");
            //}

            //Console.Write("Enter Z: ");
            //while (!double.TryParse(Console.ReadLine(), out z1))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number for Z.");
            //    Console.Write("Enter Z: ");
            //}


            //Point3D P1 = new Point3D(x1, y1, z1);


            //Console.WriteLine("Enter coordinates for Point P2:");
            //Console.Write("Enter X: ");
            //while (!double.TryParse(Console.ReadLine(), out x2))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number for X.");
            //    Console.Write("Enter X: ");
            //}

            //Console.Write("Enter Y: ");
            //while (!double.TryParse(Console.ReadLine(), out y2))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number for Y.");
            //    Console.Write("Enter Y: ");
            //}

            //Console.Write("Enter Z: ");
            //while (!double.TryParse(Console.ReadLine(), out z2))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number for Z.");
            //    Console.Write("Enter Z: ");
            //}


            //Point3D P2 = new Point3D(x2, y2, z2);


            //Console.WriteLine("P1: " + P1.ToString());
            //Console.WriteLine("P2: " + P2.ToString());


            //if (P1 == P2)
            //{
            //    Console.WriteLine("P1 and P2 are equal.");
            //}
            //else
            //{
            //    Console.WriteLine("P1 and P2 are not equal.");
            //}

            // Yes == works properly

            //Point3D[] points = new Point3D[]
            //{
            //    new Point3D(5, 10, 0),
            //    new Point3D(2, 3, 0),   
            //};

            //Array.Sort(points);

            //Console.WriteLine("Points after sorting:");
            //foreach (var point in points)
            //{
            //    Console.WriteLine(point);
            //}

            #endregion

            #region Second Project
            //double num1, num2;

            //Console.Write("Enter first number: ");
            //if (double.TryParse(Console.ReadLine(), out num1))
            //{
            //    Console.Write("Enter second number: ");
            //    if (double.TryParse(Console.ReadLine(), out num2))
            //    {
            //        Console.WriteLine($"Addition :{ MathClass.Add(num1, num2)}");
            //        Console.WriteLine($"Subtraction :{ MathClass.Subtract(num1, num2)}");
            //        Console.WriteLine($"Multiplication :{ MathClass.Multiply(num1, num2)}");
            //        Console.WriteLine($"Division :{ MathClass.Divide(num1, num2)}");

            //    }
            //    else
            //        Console.WriteLine("Enter a valid number");

            //}
            //else
            //    Console.WriteLine("Invalid inputs");



            #endregion

            #region Third Project
            //DurationClass D1 = new DurationClass(1, 10, 15);
            //D1.ToString();
            //Console.WriteLine(D1);

            //DurationClass D2 = new DurationClass(3600);
            //D2.ToString();
            //Console.WriteLine(D2);

            //DurationClass D3 = new DurationClass(7800);
            //D3.ToString();
            //Console.WriteLine(D3);

            //DurationClass D4 = new DurationClass(666);
            //D4.ToString();
            //Console.WriteLine(D4);

            //D3 = D1 + D2;
            //Console.WriteLine($"D3 = D1 + D2 : {D3}");

            //D3 = D1 + 7800; 
            //Console.WriteLine($"D3 = D1 + 7800 : {D3}");

            //D3 = 666 + D3;
            //Console.WriteLine($"D3 = 666 + D3 : {D3}");

            //D3 = ++D1;
            //Console.WriteLine($"D3 = ++D1 : {D3}");

            //D3 = --D2;
            //Console.WriteLine($"D3 = --D2 : {D3}");

            //D1 = D1 - D2;
            //Console.WriteLine($"D1 = D1 - D2 : {D1}");

            //Console.WriteLine($" D1 greater than D2? {D1 > D2}");
            //Console.WriteLine($" D1 less than or equal to D2? {D1 <= D2}");

            //if (D1) Console.WriteLine("D1 is not zero.");
            //else Console.WriteLine("D1 is zero.");

            //DateTime dateTime = D1;
            //Console.WriteLine($"D1 as DateTime: {dateTime:HH:mm:ss}");

            #endregion
        }
    }
}
