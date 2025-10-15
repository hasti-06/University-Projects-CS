using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenOrTriple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 7 == 0)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine(num * 3);
            }

        }
    }
}
