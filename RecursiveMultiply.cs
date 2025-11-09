using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveMultiply
{
    internal class Program
    {
        public static int multiply(int a, int b) {
            if (b == 0) return 0;
            else return a + multiply(a, b - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = multiply(num1, num2);
            Console.WriteLine($"{num1} * {num2} = {result}");
        }
    }
}
