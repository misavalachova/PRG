using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listy_a_slovniky
{
    internal class Program
    {
        static void PrintList(List<string> list)
        {
            foreach(string name in list)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //List
            List<string> myList = new List<string>();
            myList.Add("jedna");        //lze napsat i jednoduse "jedna",
            myList.Add("dva");          //                       "dva",
            myList.Add("tri");
            myList.Add("ctyri");
            myList.Add("pet");

            PrintList(myList);

            myList.Remove("tri");

            PrintList(myList);

            myList.RemoveAt(2);

            PrintList(myList);

            if (myList.Exists(number => number.StartsWith("d")))
            {
                Console.WriteLine("V listu je cislo zacinajici na d");
            }
            else
            {
                Console.WriteLine("V listu neni zadne cislo zacinajici na d");
            }

            

            //Dictionary

            Dictionary<string, string> spanishToCzech = new Dictionary<string, string>();
            spanishToCzech["Agua"] = "Voda";
            spanishToCzech["Hospital"] = "Nemocnice";
            spanishToCzech["electroencefalografistas"] = "Elektroencefalografové";

            foreach(KeyValuePair<string, string> translation in spanishToCzech)
            {
                string spanishWord = translation.Key;
                string czechWord = translation.Value;
                Console.WriteLine("Překlad slova " + spanishWord + " do češtiny je " +  czechWord);
            }

            if (spanishToCzech.ContainsKey("Agua"))
            {
                Console.WriteLine("Ve slovníku se vyskytuje slovo");
            }

            Console.ReadKey();
        }
    }
}
