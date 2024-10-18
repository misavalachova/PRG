using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace RecursionPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // Nacteme cislo n, pro ktere budeme pocitat jeho faktorial a n-ty prvek Fibonacciho posloupnosti.
            int factorial = Factorial(n); // Prvni zavolani pro vypocet faktorialu, ulozeni do promenne factorial.
            int fibonacci = Fibonacci(n); // Prvni zavolani pro vypocet Fibonacciho posloupnosti, ulozeni do promenne fibonacci.
            Console.WriteLine($"Pro cislo {n} je faktorial {factorial} a {n}. prvek Fibonacciho posloupnosti je {fibonacci}"); // Vypsani vysledku uzivateli.
            Console.ReadKey();
        }

        static int Factorial(int n)
        {
            //int result = 1;
            //for (int i = n; i > 1; i--)
            //{ *= i;}
            //return result.
            int result = 0;
            int number = n - 1;
            if (n!= 1)
            {
                Factorial(number - 1);
            }

            // TODO: Urci ukoncovaci podminku pro faktorial a zavolej Factorial zevnitr se spravnym parametrem / vypoctem.
            return result; // TODO: Uprav, aby Factorial vracel spravnou hodnotu.
        }

        static int Fibonacci(int n)
        {
            // TODO: Urci ukoncovaci podminku pro Fibonacciho a zavolej Fibonacci zevnitr se spravnym parametrem / vypoctem.
            return 0; // TODO: Uprav, aby Fibonacci vracel spravnou hodnotu.
        }
    }
}
