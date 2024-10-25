using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2024-2025.
 * Extended by students.
 */

namespace ArrayPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové pole a naplň ho pěti libovolnými čísly.
            int[] MyArray = { 6, 54, 85, 12, 7 };

            //TODO 2: Vypiš do konzole všechny prvky pole, zkus jak klasický for, kde i využiješ jako index v poli, tak foreach.
            Console.WriteLine("Vypsani for cyklem");
            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine(MyArray[i]);
            }
            Console.WriteLine("Vypsani foreach");
            foreach (int number in MyArray)
            {
                Console.WriteLine(number);
            }

            //TODO 3: Spočti sumu všech prvků v poli a vypiš ji uživateli.
            int sum;
            sum = MyArray.Sum();
            Console.WriteLine("Suma: " + sum);

            //foreach (int number in MyArray){ sum += number; // sum = sum + number}

            //TODO 4: Spočti průměr prvků v poli a vypiš ho do konzole.
            int average;
            average = (int)MyArray.Average();
            Console.WriteLine("Average: " + average);

            //double average = (double) sum /MyArray.Length;
            //Console.WriteLine("Average: " + average);


            //TODO 5: Najdi maximum v poli a vypiš ho do konzole.
            int max;
            //max = MyArray.Max();
            //Console.WriteLine("Maximum: " + max);

            max = MyArray[0];
            for (int i = 1;  i < MyArray.Length; i++)
            {
                if (MyArray[i] > max)
                {
                    max = MyArray[i];
                }
            }
            Console.WriteLine("Maximum: " + max);

            // pokud použiju foreach (int number in MyArray) {}, max = minintvalue

            //TODO 6: Najdi minimum v poli a vypiš ho do konzole.
            int min;
            min = MyArray.Min();
            Console.WriteLine("Minimum: " + min);

            //TODO 7: Vyhledej v poli číslo, které zadá uživatel, a vypiš index nalezeného prvku do konzole.
            int input = int.Parse(Console.ReadLine());
            int index = 0;
            bool Foundnumber = false;
            for (int i = 0; i < MyArray.Length; i++)
            {
                if (input == MyArray[i])
                {
                    Console.WriteLine("Cislo nalezeno na indexu " + i);
                    Foundnumber = true;
                    break;
                }
            }
            if ( !Foundnumber ) 
            {
                Console.WriteLine("Cislo v poli neexistuje");
            }
            

            //TODO 8: Přepiš pole na úplně nové tak, že bude obsahovat 100 náhodně vygenerovaných čísel od 0 do 9.
            Random rng = new Random();
            MyArray = new int[100]; //new int[] array2 = new int[100];
            for (int i = 0;i < MyArray.Length; i++)
            {
                MyArray[i] = rng.Next(0,10);
                Console.WriteLine(MyArray[i] + ", ");
            }
            Console.WriteLine();

            //TODO 9: Spočítej kolikrát se každé číslo v poli vyskytuje a spočítané četnosti vypiš do konzole.
            int[] counts = new int[10];
            foreach (int number in MyArray)
            {
                counts[number]++;
            }
            for (int i = 0; i < counts.Length; i++)
            {
                Console.WriteLine("Cetnost cisla" + i + ": " + counts[i]);
            }

            //TODO 10: Vytvoř druhé pole, do kterého zkopíruješ prvky z prvního pole v opačném pořadí.
            int[] MyArray2 = new int[100]; 
            for (int i = 0; i < MyArray2.Length; i++)
            {
                MyArray2[i] = MyArray[(MyArray.Length -1) -i];
                Console.WriteLine(MyArray2[i]);
            }
            Console.WriteLine();

            //Zkus is dál hrát s polem dle své libosti. Můžeš třeba prohodit dva prvky, ukládat do pole prvky nějaké posloupnosti (a pak si je vyhledávat) nebo cokoliv dalšího tě napadne

            Console.ReadKey();
        }
    }
}
