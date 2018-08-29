using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Program
    {
        // Static Public fields for holding constant information;
        public static void RandomNumbers()
        {
            V.costFood = V.rnd.Next(2000, 3000);
            V.costResearch = V.rnd.Next(1000, 5000);
            V.costAnimals = V.rnd.Next(2000, 4000);
            V.costWater = V.rnd.Next(1000, 8000);
            V.costFuel = V.rnd.Next(2000, 7000);
        }                                                // Code for RandomNumber generator
        public static void UI()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.SetCursorPosition(30, 1);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Cargo: {0}/{1}", V.curInventory = V.invFood + V.invResearch + V.invAnimals + V.invWater + V.invFuel, V.maxInventory);
            Console.SetCursorPosition(5, 1);
            Console.WriteLine("Name: {0}", V.character);
            Console.SetCursorPosition(55, 1);
            Console.WriteLine("Credits: {0}", V.credits);
            Console.SetCursorPosition(90, 1);
            Console.WriteLine("Year: {0}", V.time);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }                                                           // Code for UI
        public static double Distance(double x1, double y1, double destX, double destY)
        {
            V.distance = Math.Sqrt(Math.Pow((V.destX - x1), 2) + Math.Pow((destY - y1), 2));

            return V.distance;
        }   // Code for distance math
        public static double Velocity(double speed)
        {
            V.velocity = Math.Pow(V.speed, (10 / 3)) + Math.Pow((10 - V.speed), -11 / 3);

            return V.velocity;
        }                                       // Code for Velocity/Speed math based on Warp Factor
        
        // Code for Ships
        public static int Ship(int tier1, int tier2, int tier3)
        {
            if (V.currentShip == V.tier1Ship)
            {
                V.shipName = "Space Cruiser";
                V.maxInventory = 3;
                V.speed = 1.5;
                V.shipPrice = 5000;
                V.velocity = Velocity(V.speed);
            }
            else if (V.currentShip == V.tier2Ship)
            {
                V.shipName = "Star Explorer";
                V.maxInventory = 5;
                V.speed = 3;
                V.shipPrice = 20000;
                V.velocity = Velocity(V.speed);
            }
            else if (V.currentShip == V.tier3Ship)
            {
                V.shipName = "USS Schwiftiest Ship";
                V.maxInventory = 10;
                V.speed = 6;
                V.shipPrice = 50000;
                V.velocity = Velocity(V.speed);
            }

            return V.currentShip;
        }

        // Code with game over bool
        public static bool GameOver(int credits, double time)
        {
            bool gameOver = false;
            if ((credits < 0) || (time >= 40.0))
            {
                gameOver = true;
            }
            else
            {
                gameOver = false;
            }

            return gameOver;
        }        

        // Main Game
        public static void Main(string[] args)
        {
            V.currentShip = V.tier1Ship;
            Ship(V.tier1Ship, V.tier2Ship, V.tier3Ship);
            Planet.currentPlanet = 1;

            // string decleration
            string input;
            string shopInput;

            // Stroy Start up
            new Story().Intro();

            // Get input from console to select first ship
            input = Console.ReadLine();
            switch (input)
            {
                case "Buy":
                case "buy":
                    V.cost = 5000;
                    V.credits -= V.shipPrice;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("You decide not to buy the ship, and to take a less risky/difficult approach to life.. You decide to instead go to the nearest " +
                        "bar and spend every dime you just inherited on anything! that will make you feel better.... You died later that night, by " +
                        "an overdose from who knows how many different things... ");
                    Console.WriteLine("Press enter to exit");
                    Console.ReadLine();
                    break;
            }

            // Loop for game
            #region Game
            if (V.cost != 0)
            {
                Planet.GetPlanetName(Planet.currentPlanet);
                UI();
                Console.WriteLine("You paid {0} for your ship!!", V.cost);
                Console.WriteLine();
                Console.WriteLine("Thank you for shopping with SpaceBuggies R Us");
                System.Threading.Thread.Sleep(1200);

                UI();
                Console.WriteLine("\n Your first ship!! The {0}. V.speed: {1}. Cargo Space: {2}", V.shipName, V.speed, V.maxInventory);
                Console.ReadLine();

                // Player starts his journey exploring and buying
                do
                {
                    // Console/Menu
                    UI();
                    Console.WriteLine("You are on planet {0}! Current year is {1}!", Planet.GetPlanetName(Planet.currentPlanet), Math.Round(V.time, 2));
                    Console.WriteLine();
                    Console.WriteLine("What would you like to do?: \n" +
                        "- 'Ship'to buy a new ship\n" +
                        "- 'Buy' to buy goods\n" +
                        "- 'Sell' to sell goods\n" +
                        "- 'travel' to leave and go to the next planet!\n" +
                        "- 'inv' to check your current inventory space\n" +
                        "- 'exit' to exit the game........");

                    // Planetary options
                    shopInput = Console.ReadLine();
                    if ((shopInput != "exit") || (shopInput != "Exit"))
                    {
                        if ((shopInput == "Ship") || (shopInput == "ship"))
                        {
                            new Menu.ShipBuy().ShipMenu();
                        }
                        else if ((shopInput == "Buy") || (shopInput == "buy"))
                        {
                            new Menu.Buy().BuyMenu();
                        }
                        else if ((shopInput == "Sell") || (shopInput == "sell"))
                        {
                            new Menu.Sell().SellMenu();
                        }
                        else if ((shopInput == "Inv") || (shopInput == "inv"))
                        {
                            V.Inventory(V.maxInventory, V.curInventory);
                        }
                        else if ((shopInput == "Travel") || (shopInput == "travel"))
                        {
                            new Menu.Travel().TravelMenu();
                        }
                        else if (shopInput == "exit")
                        {
                            break;
                        }
                    }

                } while ((GameOver(V.credits, V.time) == false) && (shopInput != "exit"));
                // Game over
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Game Over!! Total play V.time: {0}.  Total credits earned: {1}.", Math.Round(V.time, 2), V.totalCredits - 10000);
                Console.ReadLine();

            }
            #endregion
        }
    }
}
