using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game2
{
    internal class Game
    {
        private Player player;
        private List<Location> locations;
        private Random random;
        private int clues;
        private bool templeDiscovered;

        public Game()
        {
            player = new Player("Hráč");
            locations = new List<Location>
            {
                new Location("Hory", new List<Event> { new Avalanche(), new MountainTrap(), new HealingHerb()}), //vypsané lokace a jejich události
                new Location("Řeka", new List<Event> { new Flood(), new CrocodileAttack(), new LostTraveler()}),
                new Location("Jeskyně", new List<Event> { new BatAttack(), new CaveCollapse() }),
                new Location("Vesnice", new List<Event> { new Merchant(), new BanditAttack() })
            };
            random = new Random();
            clues = 0;
            templeDiscovered = false;
        }

        public void Start()
        {
            Console.WriteLine("Vítejte ve hře Jumanji! Tvým cílem je dostat se k chrámu Jumanji a překonat všechny překážky.");
            while (player.Health > 0)
            {
                Console.WriteLine("\nKam se vydáš?:"); //\n pro další řádek
                for (int i = 0; i < locations.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + (locations[i].Name));
                }

                if (clues >= 3 && !templeDiscovered)
                {
                    locations.Add(new Location("Chrám Jumanji", new List<Event>())); //lokace chrám se objeví až po nalezení předmětů
                    templeDiscovered = true;
                    Console.WriteLine("Odhalil si cestu k Chrámu Jumanji!");
                }

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > locations.Count)
                {
                    Console.WriteLine("Neplatná volba."); //kontrola platného vstupu
                    continue;
                }

                choice -= 1;

                if (locations[choice].Name == "Chrám Jumanji")
                {
                    Console.WriteLine("Jupii! Dosáhl ¨si chrámu Jumanji a vyhrál hru!");
                    return;
                }

                Event gameEvent = locations[choice].GetRandomEvent(); //vybere náhodnou událost z dostupných v dané lokaci
                gameEvent.Trigger(player, this); //this - odkaz na aktuální instanci Game
            }
            Console.WriteLine("Konec hry!");
            Console.ReadKey();
        }

        public void AddClue()
        {
            clues++;
            Console.WriteLine("Získal si indicii! Počet indicií: " + (clues));
        }
    }
}
