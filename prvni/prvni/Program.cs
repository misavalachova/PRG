using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prvni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            
            int a = 0;
            do
            {
                a = rng.Next(100);

                Console.WriteLine(a);

                if (a > 50)
                {
                    Console.WriteLine("Hodnota je vetsi nez 50.");
                }
                else if (a > 25)
                {
                    Console.WriteLine("Hodnota je mezi 50 a 25.");
                }
                else
                {
                    Console.WriteLine("Hodnota je mensi nebo rovna 25.");
                }

            } while (a != 10);

            string answer = Console.ReadLine();
            bool shouldQuit;
            if (answer == "quit")
            {
                shouldQuit = true;
            }
            else 
            {
                shouldQuit = false;
            }

            bool shouldQuit2 = Console.ReadLine() == "quit" ? true : false;

            Console.ReadKey();
        }
    }
}
