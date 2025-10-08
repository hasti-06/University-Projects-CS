using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentigradeToFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the temperature in Centigrade: ");
            double centigrade = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = centigrade * (9.0 / 5) + 32;
            Console.WriteLine($"The temperature in Fahrenheit is: {fahrenheit}");
        }
    }
}
