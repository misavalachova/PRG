using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kamen_nuzky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Napis kamen, nuzky nebo papir.");
            string input;
            int ja = 0;
            int on = 0;
            int mojebody = 0;
            int jehobody = 0;
            Random rng = new Random();
            
            while (mojebody != 3 && jehobody != 3)
            {
                input = Console.ReadLine();
                switch (input)
                {
                    case "kamen":
                        ja = 1;
                        break;
                    case "nuzky":
                        ja = 2;
                        break;
                    case "papir":
                        ja = 3;
                        break;
                    default:
                        Console.WriteLine("chybny vstup, znovu prosim");
                        ja = 5;
                        break;
                }
                on = rng.Next(1,3);
                if (ja == on)
                {
                    Console.WriteLine("Remíza.");
                }
                if (ja == 1)
                {
                    if (on == 2)
                    {
                        mojebody++;
                        Console.WriteLine("Vyhrál si! Získáváš jeden bod.");
                    }

                    if(on == 3)
                    {
                        jehobody++;
                        Console.WriteLine("Prohrál jsi:( Protihráč získává bod."); 
                    }
                }
                if (ja == 2)
                {
                    if (on == 1)
                    {
                        jehobody++;
                        Console.WriteLine("Prohrál jsi:( Protihráč získává bod.");
                    }
                    if(on == 3)
                    {
                        mojebody++;
                        Console.WriteLine("Vyhrál si! Získáváš jeden bod."); 
                    }
                }
                if (ja == 3)
                {
                    if (on == 1)
                    { 
                        jehobody++;
                        Console.WriteLine("Prohrál jsi:( Protihráč získává bod.");
                    }
                    if (on == 2)
                    {
                        mojebody++;
                        Console.WriteLine("Vyhrál si! Získáváš jeden bod.");
                    }
                }

                Console.WriteLine("Tvoje momentální skóre " + mojebody + ":" + jehobody);

            }
            Console.WriteLine("Výsledné skóre je " + mojebody + ":" + jehobody);
            if (mojebody > jehobody)
            {
                Console.WriteLine("Jupí jseš super.");
            }
            else
            {
                Console.WriteLine("Trapas, tos nezabil. zkus mu to vrátit:)");
            }



            Console.ReadKey();
        }
    }
}
