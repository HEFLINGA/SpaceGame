using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Menu
    {
        public Menu()
        {

        }

        // Congrats Window when buying ship
        private static void Congrats()
        {
            Program.UI();
            Console.WriteLine("Congratulations on your new ship!!!!!");
            Console.WriteLine("You now have a new max V.speed and cargo!");
            Console.WriteLine();
            Console.WriteLine("New Max V.speed: {0}.  New Max Cargo: {1}", V.speed, V.maxInventory);
            Console.ReadLine();
        }
        public class ShipBuy
        {
            // Ship Menu for buying ships
            // Ship options
            private static int StarExplorer()
            {
                if ((V.currentShip != V.tier2Ship) && (V.credits >= 20000))
                {
                    V.credits -= 20000;
                    V.currentShip = V.tier2Ship;
                    Program.Ship(V.tier1Ship, V.tier2Ship, V.tier3Ship);
                    Congrats();
                }
                else if (V.currentShip == V.tier2Ship)
                {
                    Console.WriteLine($"You already own that ship! No need to have 2 of them.. you are but one person {V.character}");
                    Console.WriteLine("Press Enter to return to Main Menu");
                    Console.ReadLine();
                }
                else if (V.credits < 20000)
                {
                    Console.WriteLine("You are to broke to afford such a ship.. Get more credits and come back");
                    Console.WriteLine("Press Enter to return to Main Menu");
                    Console.ReadLine();
                }

                return V.currentShip;
            }
            private static int UssSchwiftiestShip()
            {
                if ((V.currentShip != V.tier3Ship) && (V.credits >= 50000))
                {
                    V.credits -= 50000;
                    V.currentShip = V.tier3Ship;
                    Program.Ship(V.tier1Ship, V.tier2Ship, V.tier3Ship);
                    Congrats();
                }
                else if (V.currentShip == V.tier3Ship)
                {
                    Console.WriteLine($"You already own that ship! No need to have 2 of them.. you are but one person {V.character}");
                    Console.WriteLine("Press Enter to return to Main Menu");
                    Console.ReadLine();
                }
                else if (V.credits < 50000)
                {
                    Console.WriteLine("You are to broke to afford such a ship.. Get more credits and come back");
                    Console.WriteLine("Press Enter to return to Main Menu");
                    Console.ReadLine();
                }

                return V.currentShip;
            }
            // Ship menu
            public static void ShipMenu()
            {
                string shipMenuInput = "";

                Program.UI();

                Console.WriteLine("What would you like to buy?: \n" +
                                        "(Type name of Ship to purchase)");
                Console.WriteLine("press 'Enter' to leave the trading post");
                Console.WriteLine();
                Console.WriteLine("Star Explorer! Price: 20000 credits. V.speed: 3. Cargo: 5");
                Console.WriteLine("USS Schwiftiest Ship! Price: 50000 credits. V.speed: 6. Cargo: 10");

                shipMenuInput = Console.ReadLine();
                switch (shipMenuInput)
                {
                    case "Star Explorer":
                    case "star explorer":
                        Console.Clear();
                        StarExplorer();
                        Program.UI();
                        break;
                    case "USS Schwiftiest Ship":
                    case "uss schwiftiest ship":
                        Console.Clear();
                        UssSchwiftiestShip();
                        Program.UI();
                        break;
                    default:
                        Console.WriteLine("Returning to Menu");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        break;

                }
            }
        }

    }
}
