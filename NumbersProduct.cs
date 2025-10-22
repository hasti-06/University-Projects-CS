using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p = 1;
            double num;
            do
            {
                Console.Write("Enter a number (0 to stop) : ");
                num = double.Parse(Console.ReadLine());
                if (num != 0)
                {
                    p *= num;
                }
            }while (num != 0);
            Console.WriteLine($"The product of all numbers is : + {p}");
        }
    }
}
