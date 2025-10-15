using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessThanTen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int numb = int.Parse(Console.ReadLine());
            if (numb < 10 && numb % 2 == 0)
            {
                Console.WriteLine("TRUE!");
            }
        }
    }
}
