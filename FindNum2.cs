using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNum2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            bool found = false;
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Enter number {i + 1} :");
                num[i] = Int32.Parse(Console.ReadLine());
            }
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == 2)
                {
                    Console.WriteLine($"Number 2 was the {i + 1}th number you entered.");
                    found = true;
                    break;
                }
            }
                if (!found)
                {
                    Console.WriteLine("You didn't enter the number 2!");
                }
            
        }
    }
}
