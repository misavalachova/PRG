using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2024-2025.
 * Extended by students.
 */

namespace _2D_Array_Playground
{
    internal class Program
    { 
        static void SetArrayToDefault(int[,] arrayToSet)
        {
            for (int i = 0; i < arrayToSet.GetLength(0); i++)
            {
                for (int j = 0; j < arrayToSet.GetLength(1); j++)
                {
                    arrayToSet[i, j] = i * 5 + j + 1;
                }
            }
        }
        static void Print2DArray(int[,] arrayToPrint)
        {
            for (int i = 0; i < arrayToPrint.GetLength(0); i++)
            {
                for (int j = 0; j < arrayToPrint.GetLength(1); j++)
                {
                    Console.Write(arrayToPrint[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové 2D pole velikosti 5 x 5, naplň ho čísly od 1 do 25 a vypiš ho do konzole (5 řádků po 5 číslech).
            int[,] array = new int[5, 5];

            SetArrayToDefault(array);
            Print2DArray(array);
            

            //TODO 2: Vypiš do konzole n-tý řádek pole, kde n určuje proměnná nRow.
            int nRow = 2;
            Console.WriteLine(nRow + ". radek");
            for (int j = 0; j < array.GetLength(1);  j++)
            {
                Console.WriteLine(array[nRow, j] + " ");
            }
            Console.WriteLine("\n");

            //TODO 3: Vypiš do konzole n-tý sloupec pole, kde n určuje proměnná nColumn.
            int nColumn = 0;
            Console.WriteLine(nColumn + ". sloupec");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine(array[i, nColumn] + " ");
            }
            Console.WriteLine("\n");

            //TODO 4: Prohoď prvek na souřadnicích [xFirst, yFirst] s prvkem na souřadnicích [xSecond, ySecond] a vypiš celé pole do konzole po prohození.
            //Nápověda: Budeš potřebovat proměnnou navíc, do které si uložíš první z prvků před tím, než ho přepíšeš druhým, abys hodnotou prvního prvku potom mohl přepsat druhý
            int rowFirst, columnFirst, rowSecond, columnSecond;
            rowFirst = columnFirst = columnSecond = 2;
            rowSecond = 3;

            Console.WriteLine("Prohazuju prvek " + array[rowFirst, columnFirst] + 
                " na pozici [" + rowFirst + ", " + columnFirst  + 
                "] " + "s prvkem " + array[rowSecond, columnSecond] + 
                " na pozici [" + rowSecond + ", " + columnSecond  + "]");

            int backup = array[rowFirst, columnFirst];
            array[rowFirst, columnFirst] = array[rowSecond, columnSecond];
            array[rowSecond, columnSecond] = backup;

            Print2DArray(array);
            SetArrayToDefault(array);

            //TODO 5: Prohoď n-tý řádek v poli s m-tým řádkem (n je dáno proměnnou nRowSwap, m mRowSwap) a vypiš celé pole do konzole po prohození.
            int nRowSwap = 0;
            int mRowSwap = 1;

            Console.WriteLine("Prohozeni " + nRowSwap + ". radku s " + mRowSwap + ". radkem");

            for (int j = 0; j < array.GetLength(1); j++)
            {
                backup = array[nRowSwap, j];
                array[nRowSwap, j] = array[mRowSwap, j];
                array[mRowSwap, j] = backup;
            }
            Print2DArray(array);
            SetArrayToDefault(array);


            //TODO 6: Prohoď n-tý sloupec v poli s m-tým sloupcem (n je dáno proměnnou nColSwap, m mColSwap) a vypiš celé pole do konzole po prohození.
            int nColSwap = 0;
            int mColSwap = 1;

            Console.WriteLine("Prohozeni " + nColSwap + ". sloupce s " + mColSwap + ". sloupcem");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                backup = array[i, nColSwap];
                array[i, nColSwap] = array[i, mColSwap];
                array[i, mColSwap] = backup;
            }
            Print2DArray(array);
            SetArrayToDefault(array);

            //TODO 7: Otoč pořadí prvků na hlavní diagonále (z levého horního rohu do pravého dolního rohu) a vypiš celé pole do konzole po otočení.
            Console.WriteLine("Prohozeni prvku na hlavni diagonale");

            for (int i = 0; i < array.GetLength(0)/2; i++)
            {
                int coord = array.GetLength(0) - i - 1;
                backup = array[i, i];
                array[i, i] = array[coord, coord];
                array[coord, coord] = backup;
            }

            Print2DArray(array);
            SetArrayToDefault(array);


            //TODO 8: Otoč pořadí prvků na vedlejší diagonále (z pravého horního rohu do levého dolního rohu) a vypiš celé pole do konzole po otočení.
            Console.WriteLine("Prohozeni prvku na vedlejsi diagonale");

            for (int i = 0; i < array.GetLength(0) / 2; i++)
            {
                int currentColumn = array.GetLength(0) - i - 1;
                backup = array[i, currentColumn];
                
            }

            Print2DArray(array);
            SetArrayToDefault(array);

            Console.ReadKey();
        }
    }
}
