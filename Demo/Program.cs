using Demo.Abstraction;
using Demo.Mapping;
using Demo.Operator_Overloading;
using Demo.Static;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Abstraction

            // 4.Abstraction
            // abstract : C# keyword [class-method-propeties]
            // abstract class
            // abstract method
            // abstract property

            // 2D Shapes

            // Shape shape = new Shape(); // Invalid
            // Note : you can't create from abstract class or an interface

            // shape.GetArea();

            // Rectangle rectangle = new Rectangle() { Dim01 = 12 , Dim02 = 3};
            // rectangle.Perimeter = 12; // invalid
            // Console.WriteLine($"Perimeter of rectangle is : {rectangle.Perimeter}");
            // Console.WriteLine($"Area of rectangle is : {rectangle.GetArea()}");

            // Square square = new Square() { Dim01=5};
            // square.Perimeter = 12; // invalid
            // Console.WriteLine($"Perimeter of square is : {square.Perimeter}");
            // Console.WriteLine($"Area of square is : {square.GetArea()}");


            #endregion

            #region Operator Overloading

            // + - * / % > < >= <= != == || &&  ! | & ! ^ >>
            // +

            // int X = 3 + 4;

            // string Y ="Hello " + "World" ; 

            // Complex Number : real + imaginary
            // 4 + 3i

            // Complex C01 = new Complex() { Real=4 , Imaginary=4};
            // Complex C02 = new Complex() { Real=4 , Imaginary=2};

            // Console.WriteLine(C01);
            // Console.WriteLine(C02);

            // Complex C03 = C01 + C02;
            // Complex C04 = C01 - null;

            // Console.WriteLine(C03);
            // Console.WriteLine(C04);

            // ++ , --
            // unary

            // int X = 12;
            // X++;

            // Console.WriteLine(X);

            // Console.WriteLine(C01);

            // Complex C05 = C01++;
            // Console.WriteLine(C05); 

            // Complex C06 = C01--;
            // Console.WriteLine(C05);

            // if (C01 >= C02)
            // {
            //  Console.WriteLine("C01 is greater than C02");
            // }
            // else
            // {
            //  Console.WriteLine("C01 is Not greater than C02");
            // }

            // bool X = true || true ;

            #endregion

            #region User-Defined Casting Operator & Manual Mapping
            // double X = 12;
            // int Y = (int) X;
            // (int) : Casting operator

            // Complex C01 = new Complex() { Real=3 , Imaginary=4 };

            // string S = (string) C01;
            // (string) : Convert  complex num to string

            // Operator Overloading
            // User Defined Casting operator

            // Console.WriteLine(S);

            // int X =(int)C01;
            // Console.WriteLine(X);

            // int X =(int) new Complex() { Real = 4, Imaginary = 7 };

            // Mapping : convert from one datatype to another

            // Code First
            // DB First

            // User [Id,Name,Email,Password,UserName,PhoneNumber,CardNumber,ExpireDate]

            // UserViewModel
            // UserDto
            // [Name,Email,PhoneNumber]

            // User user = new User(); // From Db

            // Manual mapping
            // UserDto userDto = new UserDto() 
            // { 
            //   Email=user.Email, 
            //   Name=user.Name,   
            //   PhoneNumber=user.PhoneNumber,
            // };

            // Casting operator

            // Automapper : Automatic Mapping 
            #endregion

            #region Static
            // Static : C# keyword [Class,Method,Property,Constructor,Attributes]
            // static class
            // static method
            // static property
            // static constructor
            // static attribute

            // Utilities U01 = new Utilities();
            // Utilities U02 = new Utilities();
            // Utilities U03 = new Utilities();

            // Console.WriteLine(U01.CmToInch(254)); // 100
            // Console.WriteLine(U02.CmToInch(254)); // 100
            // Console.WriteLine(U03.CmToInch(254)); // 100

            // Console.WriteLine(Utilities.CmToInch(254)); // 100
            // Console.WriteLine(Utilities.CmToInch(254)); // 100
            // Console.WriteLine(Utilities.CmToInch(254)); // 100

            // Console.WriteLine(U02.PI()); // Invalid
            // Console.WriteLine(U01.PI()); // Invalid
            // Console.WriteLine(U03.PI()); // Invalid

            // Console.WriteLine(Utilities.PI()); // 3.14
            // Console.WriteLine(Utilities.PI()); // 3.14
            // Console.WriteLine(Utilities.PI()); // 3.14

            // Utilities U01 = new Utilities(); // Invalid 
            #endregion

            #region Sealed

            // Sealed : C# keyword [Class , Methods , Properties]

            #endregion

            #region Partial

            // Employee employee = new Employee();
            // employee.

            #endregion 
        }
    }
}
