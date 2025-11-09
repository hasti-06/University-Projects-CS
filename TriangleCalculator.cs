using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleCalculator
{
    internal class Program
    {
        public static double Perimeter(double a, double b ,double c) {
            return  a + b + c;
        }

        public static double Area(double baselength, double height) {
            return (baselength * height) / 2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Triangle Perimeter: ");
            Console.WriteLine("Enter side 1: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter side 2: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter side 3: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nTriangle Area: ");
            Console.WriteLine("Enter base: ");
            double baselength = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double p = Perimeter (a, b, c);
            double area = Area(baselength, height);

            Console.WriteLine("\nPerimeter of the triangle : " + p);
            Console.WriteLine("Area of the triangle : " + area);
        }
    }
}
