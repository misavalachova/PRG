using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2024-2025.
 * Extended by students.
 */

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * ZADANI
             * Vytvor program ktery bude fungovat jako kalkulacka. Kroky programu budou nasledujici:
             * 1) Nacte vstup pro prvni cislo od uzivatele (vyuzijte metodu Console.ReadLine() - https://learn.microsoft.com/en-us/dotnet/api/system.console.readline?view=netframework-4.8.
             * 2) Zkonvertuje vstup od uzivatele ze stringu do integeru - https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number.
             * 3) Nacte vstup pro druhe cislo od uzivatele a zkonvertuje ho do integeru. (zopakovani kroku 1 a 2 pro druhe cislo)
             * 4) Nacte vstup pro ciselnou operaci. Rozmysli si, jak operace nazves. Muze to byt "soucet", "rozdil" atd. nebo napr "+", "-", nebo jakkoliv jinak.
             * 5) Nadefinuj integerovou promennou result a prirad ji prozatimne hodnotu 0.
             * 6) Vytvor podminky (if statement), podle kterych urcis, co se bude s cisly dit podle zadane operace
             *    a proved danou operaci - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements.
             * 7) Vypis promennou result do konzole
             * 
             * Rozsireni programu pro rychliky / na doma (na poradi nezalezi):
             * 1) Vypis do konzole pred nactenim kazdeho uzivatelova vstupu co po nem chces (aby vedel, co ma zadat)
             * 2) a) Kontroluj, ze uzivatel do vstupu zadal, co mel (cisla, popr. ciselnou operaci). Pokud zadal neco jineho, napis mu, co ma priste zadat a program ukoncete.
             * 2) b) To same, co a) ale misto ukonceni programu opakovane cti vstup, dokud uzivatel nezada to, co ma
             *       - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-while-statement
             * 3) Umozni uzivateli zadavat i desetinna cisla, tedy prekopej kalkulacku tak, aby umela pracovat s floaty
             */






            float first = LoadNumber();//Povolame funkci napsanou nize 'LoadNumber', nacita vstup (zadane cislo) od uzivatele
            float second = LoadNumber(); //To same provadi s druhou promennou
            float result = Calculate(first, second); //Povolame funkci Calculate a uvedeme cisla s kterymi pracujeme
            Console.WriteLine("Vysledek je " + result); //Nyni uz jen vypise vysledek do konzole
            Console.ReadKey(); //Toto nech jako posledni radek, aby se program neukoncil ihned, ale cekal na stisk klavesy od uzivatele.
        }
        static float LoadNumber()
        {
            Console.WriteLine("zadej číslo"); //Do konzole se vypisou instrukce uzivateli co ma zadat
            float number; //Zavedeme si novou promennou float
            while (!float.TryParse(Console.ReadLine(), out number)) //Timto overujeme, zda uzivatel nezada neplatnou hodnotu
            {
                Console.WriteLine("Neplatne cislo, zadej prosim znovu"); 
            }   
            return number; //vraceni promenne
        }
        static float Calculate(float firstNumber, float secondNumber) //Vytvorime si funkci 'Calculate' pro operace, ktere budeme provadet se zadanymi cisly, do zavorek musime zadat dva nami pojmenovane parametry
        {
            Console.WriteLine("Nyni napis, kterou operaci chces provest: soucet, rozdil, soucin, podil, mocneni, odmocneni cisla 1, odmocneni cisla 2");
            string input = Console.ReadLine(); //Nacteme vstup od uzivatele, tedy zadanou operaci podle instrukci
            float result = 0; //promenna s vysledkem, prozatim priradime hodnotu nula
            switch (input) // pouzijeme podminku, abychom rozeznali zadane operace
            { //switch narozdil of
                case "soucet": // v pripade, ze uzivatel napise soucet
                    result = firstNumber + secondNumber;
                    break; //ukonceni pripadu
                case "rozdil":
                    result = firstNumber - secondNumber;
                    break;
                case "soucin":
                    result = firstNumber * secondNumber;
                    break;
                case "podil":
                    result = firstNumber / secondNumber;
                    break;
                case "mocneni":
                    result = (float)Math.Pow((double)firstNumber, (double)secondNumber); //Vypocita prvni cislo umocnene na druhe zadane cislo
                    break;
                case "odmocneni cisla 1":
                    
                    
                        if (firstNumber < 0)
                        {
                            Console.WriteLine("Ze zaporneho cisla nelze spocitat odmocninu");
                        }
                        else
                        {
                            result = (float)Math.Sqrt((double)firstNumber);
                        }
                    break;
                case "odmocneni cisla 2":
                    if (secondNumber < 0)
                    {
                        Console.WriteLine("Ze zaporneho cisla nelze spocitat odmocninu");
                    }
                    else
                    {
                        result = (float)Math.Sqrt((double)secondNumber);
                    }
                    break;
                default: //pokud se zadana hodnota od uzivatele neshoduje s zadnou z vyjmenovanych, povazuje se za spatne zadanou a zada se znovu
                    Console.WriteLine("Spatne zadana operace, prosim napis ji znovu");

                    break;
            }
            
            return result; //vrati vyslednou hodnotu, ktera se pote pouzije v main



        }
        

    }
}
