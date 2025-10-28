using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            int odd = 0;
            int even = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter number{0} :", i + 1);
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine($"You entered {even} even numbers, and {odd} odd numbers.");
            Console.ReadKey();
                

        }
    }
}
