using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    internal class Program
    {
        static Random rnd = new Random(); //Zapíšeme sem, aby proměnná byla definovaná v celém programu
        static char[,] playerBoard = new char[10, 10];
        static char[,] computerBoard = new char[10, 10];
        static char[,] playerView = new char[10, 10]; //Pole pocitace pouze s vodou, ktere vidi hrac a utoci na nej

        static void PrintBoard(char[,] board)
        {
            Console.WriteLine("   A B C D E F G H I J"); // Popisky sloupcu
            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (i + 1 < 10)
                    Console.Write(" " + (i + 1)); // pred jednocifernymi cisly bude mezera, aby cislo 10 bylo na stejne urovni
                else
                    Console.Write((i + 1).ToString()); //pro cislo 10, s pomoci ChatGPT
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(" " + board[i, j]); //mezery pro prehlednost
                }
                Console.WriteLine();
            }
        }

        static void DefaultBoard(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = '~'; // oznacuje vodu
                }
            }
        }

        static bool ValidateInput(string input, out int x, out int y, out char orientation) //Kontroluje, zda vstup od uzivatele odpovida zadanemu formatu souradnic, dale vrati souradnice x,y, coz jsou indexy
        {
            x = -1;
            y = -1;
            orientation = ' ';  //vsechny promenne na zacatku nastavime, nejlepe na neplatne hodnoty
            char column = input[0];

            if (input.Length == 3)
            {
                if (char.IsLetter(column) && int.TryParse(input.Substring(1, 1), out x) && (input[2] == 'H' || input[2] == 'V')) //Vyuziti Substring s pomoci ChatGPT
                {
                    x--; //prevedeme na index, indexovani od nuly, proto vzdy cislo o 1 mensi
                    y = column - 'A';  //vypocita se rozdil mezi hodnotami pismen, hodnoty ASCII nalezeny na internetu
                    orientation = input[2];
                    return true;
                }
                else
                {
                    return false; //v pripade nevyhovujiciho formatu hrac musi zadat souradnice znovu (ve funkci Ships)
                }
            }
            else if (input.Length == 4) //Pro pripad dvouciferného cisla 10
            {
                if (char.IsLetter(column) && int.TryParse(input.Substring(1, 2), out x) && (input[3] == 'H' || input[3] == 'V')) //vyhovujici format
                {
                    x--; // Prevod na index
                    y = column - 'A';
                    orientation = input[3];
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        static void Ships(char[,] board, bool playerTurn)
        {

            Dictionary<string, int> ships = new Dictionary<string, int>  //slovnik pro lode a jejich hodnoty (velikosti)
            {
            { "Letadlová loď", 5 },
            { "Bitevní loď", 4 },
            { "Křižník", 3 },
            { "Ponorka", 3 },
            { "Torpédoborec", 2 }
            };

            foreach (KeyValuePair<string, int> ship in ships) //cyklus, ve kterem se vse zopakuje pro kazdou lod ze slovniku
            {
                bool placed = false; //nastavíme úvodní hodnotu
                while (!placed)
                {
                    if (playerTurn) //rozmistuje hrac
                    {
                        Console.WriteLine("Zadejte souřadnice a orientaci pro loď " + ship.Key + " o velikosti " + ship.Value + " (např. A1H, H pro vodorovně, V pro svisle)");
                        PrintBoard(playerBoard);
                        string input = Console.ReadLine();
                        if (ValidateInput(input, out int x, out int y, out char orientation)) //Funkce pro kontrolu souradnic, pokud jsou platne
                        {
                            placed = PlaceShips(board, x, y, ship.Value, orientation); //Privolame funkci pro umisteni lode, velikost lode vezmeme ze slovniku
                            if (!placed) //pokud se nezdarilo umistit
                                Console.WriteLine("Nelze umístit loď. Zkuste to znovu.");
                        }
                        else
                        {
                            Console.WriteLine("Neplatně zadané souřadnice");
                        }
                    }
                    else //pocitac
                    {
                        int x = rnd.Next(0, 10); 
                        int y = rnd.Next(0, 10);
                        char orientation;
                        if (rnd.Next(0, 2) == 0) //Nahodne cislo 0 nebo 1, 0 priradime H, 1 priradime V
                        {
                            orientation = 'H';
                        }
                        else
                        {
                            orientation = 'V';
                        }
                        placed = PlaceShips(board, x, y, ship.Value, orientation); //uspesne rozmistene lode
                    }
                }
            }
        }
        static bool PlaceShips(char[,] board, int x, int y, int size, char orientation)
        {
            if (orientation == 'V') //pro vertikalni umisteni
            {
                if (x + size > 10) //Kontrolujeme, aby lod nepresahovala velikost pole, v tomto pripade dolni okraj pole
                {
                    return false; 
                }
                else
                {

                    for (int i = 0; i < size; i++)
                    {
                        if (board[x + i, y] != '~') //pokud alespon jedno policko neni voda, je obsazene a nelze lod umistit
                        {
                            return false;

                        }
                        else
                        {
                            board[x + i, y] = 'S'; //umistit lod, znacime jak S - ship
                        }
                    }
                }

            }
            else if (orientation == 'H') //pro horizontalni umisteni
            {
                if (y + size > 10) //Kontrolujeme, aby lod nepresahovala velikost pole, v tomto pripade dolni okraj pole
                {
                    return false;
                }
                else
                {
                    for (int i = 0; i < size; i++) 
                    {
                        if (board[x, y + i] != '~')
                        {
                            return false; 
                        }
                        else
                        {
                            board[x, y + i] = 'S';
                        }

                    }
                }

            }
            else
            {
                return false; //pokud orientace neni H ani V, k tomu by ovsem dojit ani nemelo diky funkci ValidateInput
            }

            return true; // vraci true, pokud se lod uspesne umistila
        }

        static void PlayerTurn() 
        {
            Console.WriteLine("Zadej souřadnice, kam vystřelíš, např. A1, C4, atd");
            string input = Console.ReadLine();
            if (ValidateInput(input + 'H', out int x, out int y, out _)) // orientaci k vystrelu nepotrebujeme, ale pripiseme H, aby nepovazoval vstup za neplatny, out _ s radou programu - nyni nepotrebujeme promennou orientation
            {
                if (computerBoard[x, y] == '~') 
                {
                    Console.WriteLine("Minul jsi");
                    computerBoard[x, y] = '_';
                    playerView[x, y] = '_'; 
                }
                else if (computerBoard[x, y] == 'S')
                {
                    Console.WriteLine("Zásah! ");
                    computerBoard[x, y] = 'X';
                    playerView[x, y] = 'X';
                }
                else
                {
                    Console.WriteLine("Na toto místo si již střílel");
                    PlayerTurn(); //mozne hrat znovu
                }
            }
            else
            {
                Console.WriteLine("Neplatně zadané souřadnice, zadej prosím znovu");
                PlayerTurn();
            }
        }

        static void ComputerTurn()
        {
            int x = rnd.Next(1, 10);
            int y = rnd.Next(1, 10);

            if (playerBoard[x, y] == '~')
            {
                Console.WriteLine("Počítač minul!");
                playerBoard[x, y] = '_';
            }
            else if (playerBoard[x, y] == 'S')
            {
                Console.WriteLine("Ale ne! Počítač zasáhl tvou loď:(");
                playerBoard[x, y] = 'X';
            }
            else
            {
                ComputerTurn(); //na misto uz se trefil, proto hraje jeste jednou
            }

        }

        static bool ShipsSunked(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == 'S') //vyhrava, pokud se v poli nevyskytuje zadne S
                        return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            DefaultBoard(playerBoard); //Na zacatku dame vsem polim zakladni podobu, tedy vsude vodu ~
            DefaultBoard(computerBoard);
            DefaultBoard(playerView);

            Console.WriteLine("Ahoj! Pojď si s počítačem zahrát lodě!");
            Console.WriteLine("Pro start hry stiskni jakoukoli klávesu");
            Console.ReadKey();

            Console.WriteLine("Takhle budou vypadat vaše pole");
            PrintBoard(playerBoard); //Funkce vykresli pole do konzole

            Console.WriteLine("Stiskni libovolnou klávesu pro pokračování...");
            Console.ReadKey(); //Pro prehlednost

            Console.WriteLine("Rozmísti své lodě.");
            Ships(playerBoard, playerTurn: true); //Funkce pro rozmisteni poli, bool promenna playerTurn urcuje, kdo rozmistuje lode, tedy nyni hrac

            Console.WriteLine("Teď počítač rozmísťuje své lodě.");
            Ships(computerBoard, playerTurn: false);

            Console.WriteLine("Lodě rozmístěny! Hra může začít!");

            while (true) //Potrebujeme cyklus, ktery neskonci, dokud nekdo nevyhraje, proto nezadame podminky
            {
                Console.WriteLine("Jsi na řadě");
                PrintBoard(playerBoard);
                Console.WriteLine(" "); //pro prehlednost
                PrintBoard(playerView);

                PlayerTurn();

                if (ShipsSunked(computerBoard))
                {
                    PrintBoard(playerView);
                    Console.WriteLine("Jupii! Vyhrál jsi!");
                    break;  //break ukonci cyklus, v pripade, ze nekdo vyhral 
                }

                Console.WriteLine("Nyní hraje počítač");

                ComputerTurn();

                if (ShipsSunked(playerBoard))
                {
                    PrintBoard(playerBoard);
                    Console.WriteLine("Ajajaj, počítač potopil všechny tvé lodě, prohrál jsi:(");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
