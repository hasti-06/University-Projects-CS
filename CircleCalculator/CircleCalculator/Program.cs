using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double circumference = 2 * 3.14 * radius;
            double area = 3.14 * radius * radius;
            Console.WriteLine($"The circumference of the circle is: {circumference}");
            Console.WriteLine($"The area of the circle is: {area}");
        }
    }
}
