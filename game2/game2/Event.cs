using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game2
{
    abstract class Event
    {
        public abstract void Trigger(Player player, Game game);
    }
    class Avalanche : Event
    {
        public override void Trigger(Player player, Game game) //všechny události dědí z abstraktní třídy event
        {
            Console.WriteLine("Lavina! Musíš se schovat!");

            // Nabídneme hráči několik možností jak reagovat
            Console.WriteLine("Vyber si jednu z možností:");
            Console.WriteLine("1 - Ukrýt se pod skalami.");
            Console.WriteLine("2 - Utéct.");
            Console.WriteLine("3 - Použít lano k útěku.");
            Console.WriteLine("4 - Použít mapu a schovat se v nějaké jeskyni.");

            // Přečteme volbu hráče
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Ukrytí pod skalami
                    Console.WriteLine("Schovali jste se pod skalami. Lavina vás minula.");
                    player.Health -= 10; // Hráč utrpí menší zranění
                    Console.WriteLine("Zdraví hráče: " + (player.Health));
                    break;

                case "2":
                    // Pokus o útěk
                    Console.WriteLine("Pokusil ses se utéct, ale lavina vás dohnala!");
                    player.Health -= 30; // Hráč utrpí větší zranění při útěku
                    Console.WriteLine("Zdraví hráče: " + (player.Health));
                    break;

                case "3":
                    // Použití lana k útěku (musí být v inventáři)
                    if (player.Inventory.Any(item => item is Rope)) // Hledáme, zda hráč má lano, s pomocí ChatGPT
                    {
                        Console.WriteLine("Použil si lano k úniku! Lavina vás minula.");
                        player.Inventory.Remove(player.Inventory.Find(item => item is Rope)); // Lano se použije a odstraní
                    }
                    else
                    {
                        Console.WriteLine("Nemáš lano, nemůžeš použít tuto možnost.");
                        player.Health -= 20; // Hráč utrpí zranění, protože nemá lano
                    }
                    Console.WriteLine("Zdraví hráče: " + (player.Health));
                    break;

                case "4":
                    // Schování v jeskyni (s možností mít mapu v inventáři)
                    if (player.Inventory.Any(item => item is Map)) // Hledáme, zda hráč má mapu
                    {
                        Console.WriteLine("Použil si mapu a našel bezpečnou jeskyni. Lavina tě minula.");
                        player.Inventory.Remove(player.Inventory.Find(item => item is Map)); // Mapa se použije a odstraní
                    }
                    else
                    {
                        Console.WriteLine("Nemáš mapu, takže se ti nepodařilo najít bezpečnou jeskyni.");
                        player.Health -= 20; // Hráč utrpí zranění
                    }
                    Console.WriteLine("Zdraví hráče: " + (player.Health));
                    break;

                default:
                    Console.WriteLine("Neplatná volba. Lavina tě dohnala!");
                    player.Health -= 25; // Hráč utrpí zranění při neplatně zadané volbě
                    Console.WriteLine("Zdraví hráče: " + (player.Health));
                    break;
            }
        }
    }

    class MountainTrap : Event
    {
        public override void Trigger(Player player, Game game)
        {
            Console.WriteLine("Spadl si do horské pasti!");

            // Nabídneme hráči několik možností jak reagovat
            Console.WriteLine("Vyber si jednu z možností:");
            Console.WriteLine("1 - Pokusíš se vydrápat zpět na horu.");
            Console.WriteLine("2 - Použiješ lano k záchraně.");
            Console.WriteLine("3 - Pokusíš se křičet o pomoc.");
            Console.WriteLine("4 - Snažíš se vydržet a čekat na pomoc.");

            // Přečteme volbu hráče
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Pokusil ses vydrápat zpět na horu, ale zranil ses.");
                    player.Health -= 20; 
                    Console.WriteLine($"Zdraví hráče: {player.Health}");
                    break;

                case "2":
                    if (player.Inventory.Any(item => item is Rope)) // Hledáme, zda hráč má lano
                    {
                        Console.WriteLine("Použil si lano k záchraně a vyšplhal zpět na bezpečné místo.");
                        player.Inventory.Remove(player.Inventory.Find(item => item is Rope)); // Lano se použije a odstraní
                    }
                    else
                    {
                        Console.WriteLine("Nemáš lano, nemůžeš použít tuto možnost.");
                        player.Health -= 30; // Hráč utrpí větší zranění, protože nemá lano
                    }
                    Console.WriteLine("Zdraví hráče: " + (player.Health));
                    break;

                case "3":
                    Console.WriteLine("Začal si křičet o pomoc. Po chvíli tě někdo slyší a přichází na pomoc.");
                    player.Health += 10; // Hráč získá trochu zdraví díky pomoci
                    Console.WriteLine("Zdraví hráče: " + (player.Health));
                    break;

                case "4":
                    Console.WriteLine("Rozhodl ses čekat na pomoc. Po několika hodinách tě zachránili, ale utrpěl si zranění při čekání.");
                    player.Health -= 10; 
                    Console.WriteLine("Zdraví hráče: " + (player.Health));
                    break;

                default:
                    Console.WriteLine("Neplatná volba. Zůstal si v pasti.");
                    player.Health -= 25;
                    Console.WriteLine("Zdraví hráče: " + (player.Health));
                    break;
            }
        }
    }

    class HealingHerb : Event
    {
        public override void Trigger(Player player, Game game)
        {
            Console.WriteLine("Našel si léčivou bylinu! Vyléčila tě a získáváš zdraví");
            player.Health += 20;
            Console.WriteLine("Zdraví hráče: " + player.Health);
        }
    }

    class Flood : Event
    {
        public override void Trigger(Player player, Game game)
        {
            Console.WriteLine("Povodeň tě smetla!");
            Console.ReadKey();
            Console.WriteLine("Vyber si jednu z možností:");
            Console.WriteLine("1 - Snažíte se utéct do bezpečí.");
            Console.WriteLine("2 - Použijete lano k záchraně.");
            Console.WriteLine("3 - Schováte se do nějaké budovy.");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Pokusil ses utéct, ale voda tě dohnala.");
                    player.Health -= 25;
                    Console.WriteLine("Zdraví hráče: " + (player.Health));
                    break;

                case "2":
                    if (player.Inventory.Any(item => item is Rope)) // Hledáme, zda hráč má lano
                    {
                        Console.WriteLine("Použil si lano k záchraně a udržel ses nad vodou.");
                        player.Inventory.Remove(player.Inventory.Find(item => item is Rope)); // Lano se použije a odstraní
                    }
                    else
                    {
                        Console.WriteLine("Nemáš lano, nemůžeš použít tuto možnost.");
                        player.Health -= 30;
                    }
                    Console.WriteLine("Zdraví hráče: " + (player.Health));
                    break;

                case "3":
                    Console.WriteLine("Schoval ses do budovy a vyhnul ses většině vody, utrpěl si ale menší zranění.");
                    player.Health -= 10;
                    Console.WriteLine("Zdraví hráče: " + (player.Health));
                    break;

                default:
                    Console.WriteLine("Neplatná volba. Povodeň tě vzala s sebou:(.");
                    player.Health -= 40;
                    Console.WriteLine("Zdraví hráče: " + (player.Health));
                    break;
            }
        }
    }

    class CrocodileAttack : Event
    {
        public override void Trigger(Player player, Game game)
        {
            Console.WriteLine("Napadl tě krokodýl!");

            Console.WriteLine("Vyber si jednu z možností:");
            Console.WriteLine("1 - Bojovat s krokodýlem.");
            Console.WriteLine("2 - Pokusit se utéct.");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    if (player.Inventory.Any(item => item is Weapon))
                    {
                        Console.WriteLine("Bojuješ s krokodýlem se zbraní!");
                        player.Health -= 10;
                        Console.WriteLine("Zdraví hráče: " + player.Health);
                    }
                    else
                    {
                        Console.WriteLine("Nemáte žádnou zbraň, krokodýl vás zranil!");
                        player.Health -= 20;
                        Console.WriteLine("Zdraví hráče: " + player.Health);
                    }
                    break;

                case "2":
                    Random rnd = new Random();
                    int escapeChance = rnd.Next(1, 101); // Generování náhodného čísla pro šanci na únik
                    if (escapeChance <= 50) // 50% šance na únik
                    {
                        Console.WriteLine("Úspěšně jste se vyhnuli krokodýlovi!");
                    }
                    else
                    {
                        Console.WriteLine("Nezvládl si útěk, krokodýl tě kousl!");
                        player.Health -= 30;
                        Console.WriteLine("Zdraví hráče: " + player.Health);
                    }
                    break;

                default:
                    Console.WriteLine("Neplatná volba. Krokodýl tě kousnul!");
                    player.Health -= 25;
                    Console.WriteLine("Zdraví hráče: " + player.Health);
                    break;
            }
        }
    }

    class LostTraveler : Event
    {
        public override void Trigger(Player player, Game game)
        {
            Console.WriteLine("Potkal si ztraceného cestovatele. Vypadá vyčerpaně a žádá o pomoc.");
            Console.WriteLine("Co chceš udělat?");
            Console.WriteLine("1 - Pomoci mu.");
            Console.WriteLine("2 - Ignorovat ho a pokračovat v cestě.");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Rozhodl ses pomoci cestovateli.");
                    Console.WriteLine("Cestovatel ti poděkoval a dal ti užitečný předmět.");
                    Random rnd = new Random();
                    int itemChoice = rnd.Next(1, 4); // náhodně vybereme předmět, který hráč dostane
                    switch (itemChoice)
                    {
                         case 1:
                             player.Inventory.Add(new Map());
                             Console.WriteLine("Obdržel jsi mapu!");
                             break;
                         case 2:
                             player.Inventory.Add(new Rope());
                             Console.WriteLine("Obdržel jsi lano!");
                             break;
                         case 3:
                             player.Inventory.Add(new Weapon());
                             Console.WriteLine("Obdržel jsi zbraň!");
                             break;
                    }

                        game.AddClue();
                    break;

                case "2":
                    Console.WriteLine("Rozhodl ses ignorovat cestovatele a pokračuješ dál.");
                    break;

                default:
                    Console.WriteLine("Neplatná volba. Cestovatel se na tebe zamračil a odešel.");
                    break;
            }
        }
    }
    class Merchant : Event
    {
        public override void Trigger(Player player, Game game)
        {
            Console.WriteLine("Potkal si obchodníka, který ti nabízí následující předměty k prodeji:");

            Console.WriteLine("1 - Lano");
            Console.WriteLine("2 - Mapa");
            Console.WriteLine("3 - Zbraň");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Rozhodl ses koupit lano.");
                    player.Inventory.Add(new Rope());
                    break;

                case "2":
                    Console.WriteLine("Rozhodl ses koupit mapu.");
                    player.Inventory.Add(new Map());
                    break;

                case "3":
                    Console.WriteLine("Rozhodl ses koupit zbraň.");
                    player.Inventory.Add(new Weapon());
                    break;

                default:
                    Console.WriteLine("Neplatná volba. Nic si neodneseš:(.");
                    break;
            }

            game.AddClue();
        }
    }

    class BanditAttack : Event
    {
        public override void Trigger(Player player, Game game)
        {
            Console.WriteLine("Napadli tě bandité a ukradli ti předměty!");
            if (player.Inventory.Count > 0)
            {
                player.Inventory.RemoveAt(0);
                Console.WriteLine("Ztratil si jeden předmět z inventáře.");
            }
            else
            {
                Console.WriteLine("Neměl si žádné předměty k ukradení.");
            }
        }
    }

    class BatAttack : Event //více propracovaná, využívá metodu random, nestihla jsem doplnit i u ostních událostí
    {
        public override void Trigger(Player player, Game game)
        {
            Console.WriteLine("Znenadání na tebe zaútočí netopýr!");
            Console.WriteLine("Máš několik možností:");
            Console.WriteLine("1. Bojovat");
            Console.WriteLine("2. Utéct");
            Console.WriteLine("3. Schovat se");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Fight(player, game);
                    break;
                case "2":
                    Flee(player, game);
                    break;
                case "3":
                    Hide(player, game);
                    break;
                default:
                    Console.WriteLine("Neplatná volba, zkus to znovu.");
                    Trigger(player, game);
                    break;
            }
        }

        private void Fight(Player player, Game game)
        {
            Random rand = new Random();
            int damage = rand.Next(10, 30);

            Console.WriteLine("Rozhodl ses bojovat! Poškodil jsi netopýra!");
            player.Health -= damage;
            Console.WriteLine("Ztratil jsi " + (damage) + " zdraví. Tvé zdraví je nyní " + (player.Health));

        }

        private void Flee(Player player, Game game)
        {
            Random rand = new Random();
            int successChance = rand.Next(1, 101);

            if (successChance <= 50)
            {
                Console.WriteLine("Podařilo se ti utéct před netopýrem!");
            }
            else
            {
                int damage = rand.Next(5, 15);
                Console.WriteLine("Neutekl jsi dostatečně rychle a netopýr tě zasáhl!");
                player.Health -= damage;
                Console.WriteLine("Ztratil jsi " + (damage) + " zdraví. Tvé zdraví je nyní " + (player.Health));

            }
        }

        private void Hide(Player player, Game game)
        {
            Random rand = new Random();
            int successChance = rand.Next(1, 101);

            if (successChance <= 70)
            {
                Console.WriteLine("Podařilo se ti schovat a netopýr tě nevidí.");
            }
            else
            {
                int damage = rand.Next(5, 10);
                Console.WriteLine("Netopýr tě přeci jen našel!");
                player.Health -= damage;
                Console.WriteLine("Ztratil jsi " + (damage) + " zdraví. Tvé zdraví je nyní " + (player.Health));

               
            }
        }
    }


    class CaveCollapse : Event
    {
        public override void Trigger(Player player, Game game)
        {
            Console.WriteLine("Jeskyně se začíná řítit! Musíš rychle jednat.");
            Console.WriteLine("Máš několik možností:");
            Console.WriteLine("1. Utéct");
            Console.WriteLine("2. Použít lano pro záchranu");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    EscapeCave(player, game);
                    break;
                case "2":
                    UseRope(player, game);
                    break;
                default:
                    Console.WriteLine("Neplatná volba, ztratil si čas a tím i zdraví:(");
                    player.Health -= 30;
                    Console.WriteLine("Zdraví hráče: " + player.Health);
                    break;
            }
        }

        private void EscapeCave(Player player, Game game)
        {
            Random rand = new Random();
            int successChance = rand.Next(1, 101);

            if (successChance <= 50)
            {
                Console.WriteLine("Podařilo se ti utéct před sesuvem země!");
            }
            else
            {
                int damage = rand.Next(15, 30);
                Console.WriteLine("Sesuv tě zasáhl, ale podařilo se ti alespoň částečně utéct.");
                player.Health -= damage;
                Console.WriteLine("Ztratil si " + (damage) + " zdraví. Tvé zdraví je nyní " + (player.Health));

            }
        }

        private void UseRope(Player player, Game game)
        {
            Item ropeItem = player.Inventory.Find(item => item is Rope);

            if (ropeItem != null)
            {
                Console.WriteLine("Použil si lano, které ti pomohlo uniknout ze zřícené jeskyně.");
                player.Inventory.Remove(ropeItem);
            }
            else
            {
                Console.WriteLine("Nemáš lano, nemůžeš ho použít.");
                EscapeCave(player, game);
            }
        }


    }
}
