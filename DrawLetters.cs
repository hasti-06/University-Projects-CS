using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a letter (I, H, or E): ");
            string letter = Console.ReadLine().ToUpper();
            switch (letter)
            {
                case "I":
                    for (int i = 0; i < 5; i++)
                    {
                        if (i == 0 || i == 4)
                        {
                            Console.WriteLine("*****");
                        }
                        else { Console.WriteLine("  *  "); }
                    }
                    break;
                case "H":
                    for (int i = 0; i < 5; i++)
                    {
                        if (i == 2) { Console.WriteLine("*****"); }
                        else { Console.WriteLine("*   *"); }
                    }
                    break;
                case "E":
                    for (int i = 0; i < 5; i++) {
                        if (i == 0 || i == 2 || i == 4) { Console.WriteLine("*****"); }
                        else { Console.WriteLine("*"); }
                    }
                    break;
                default:
                    Console.WriteLine("Invalid letter!");
                    break;
            }
        }
    }
}
