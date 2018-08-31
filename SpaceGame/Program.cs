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
            V.costFood = V.rnd.Next(2000, 3500);
            V.costResearch = V.rnd.Next(1000, 5500);
            V.costAnimals = V.rnd.Next(2000, 5000);
            V.costWater = V.rnd.Next(1000, 8000);
            V.costDarkMatter = V.rnd.Next(40000, 65000);
        }                                                // Code for RandomNumber generator
        public static void UI()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(5, 1);
            Console.WriteLine("Name: {0}", V.character);
            Console.SetCursorPosition(28, 1);            
            Console.WriteLine("Cargo: {0}/{1}", V.curInventory = V.invFood + V.invResearch + V.invAnimals + V.invWater + V.invDarkMatter, V.maxInventory);
            Console.SetCursorPosition(52,1);
            Console.WriteLine("Fuel: {0}/{1}", Ship.curFuel, Ship.ShowShipMaxFuel(Ship.currentShip));
            Console.SetCursorPosition(75, 1);
            Console.WriteLine("Credits: {0}", V.credits);
            Console.SetCursorPosition(105, 1);
            Console.WriteLine("Year: {0}", V.time);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }                                                           // Code for UI
        public static double Distance(double x1, double y1, double destX, double destY)
        {
            V.distance = Math.Sqrt(Math.Pow((destX - x1), 2) + Math.Pow((destY - y1), 2));

            return V.distance;
        }   // Code for distance math
        public static double Velocity(double speed)
        {
            V.velocity = Math.Pow(speed, (10 / 3)) + Math.Pow((10 - speed), -11 / 3);

            return V.velocity;
        }                                       // Code for Velocity/Speed math based on Warp Factor
        
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
            Ship.currentShip = 1;
            new Ship().ShipName("Star Cruiser");
            new Ship().ShipSpeed(1.5);
            new Ship().ShipVelocity(Velocity(3));
            new Ship().ShipMaxFuel(10);
            Planet.currentPlanet = 1;
            RandomNumbers();

            // Variable Decleration
            string input;
            string shopInput;
            int cost = 0;

            // Stroy Start up
            new Story().Intro();

            // Get input from console to select first ship
            input = Console.ReadLine();
            switch (input)
            {
                case "Buy":
                case "buy":
                    cost = 5000;
                    V.credits -= 5000;
                    new Ship().ShipCargo(3);
                    Ship.curFuel = 10;
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
            if (cost != 0)
            {
                Planet.GetPlanetName(Planet.currentPlanet);
                UI();
                Console.SetCursorPosition(44, 12);
                Console.WriteLine("You paid {0} for your ship!!", cost);
                Console.WriteLine();
                Console.SetCursorPosition(36, 13);
                Console.WriteLine("Thank you for shopping with SpaceBuggies R Us");
                Menu.ShowLoadingScreen();

                UI();
                Console.SetCursorPosition(29, 13);
                Console.WriteLine("Your first ship!! The {0}. Speed: {1}. Cargo Space: {2}", 
                    Ship.ShowShipName(Ship.currentShip), 
                    Ship.ShowShipSpeed(Ship.currentShip), 
                    V.maxInventory);
                Menu.ShowLoadingScreen();

                // Player starts his journey exploring and buying
                do
                {
                    // Console/Menu
                    UI();
                    Console.WriteLine("You are on planet {0}! Current year is {1}!", 
                        Planet.GetPlanetName(Planet.currentPlanet), 
                        Math.Round(V.time, 2));

                    Console.WriteLine();
                    Console.WriteLine("What would you like to do?: \n" +
                        "- 'Ship'to buy a new ship or buy Fuel for your current one\n" +
                        "- 'Buy' to buy goods\n" +
                        "- 'Sell' to sell goods\n" +
                        "- 'travel' to see planets in range!\n" +
                        "- 'inv' to check your current inventory space");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("- 'exit' to exit the game........");

                    // Planetary options
                    shopInput = Console.ReadLine().ToLower();
                    if (shopInput != "exit")
                    {
                        if (shopInput == "ship")
                        {
                            new Menu.ShipBuy().ShipMenu();
                        }
                        else if (shopInput == "buy")
                        {
                            new Menu.Buy().BuyMenu();
                        }
                        else if (shopInput == "sell")
                        {
                            new Menu.Sell().SellMenu();
                        }
                        else if (shopInput == "inv")
                        {
                            V.Inventory(V.maxInventory, V.curInventory);
                        }
                        else if (shopInput == "travel")
                        {
                            new Menu().TravelMenu();
                        }
                        else if (shopInput == "exit")
                        {
                            break;
                        }
                    }

                } while ((GameOver(V.credits, V.time) == false) && (shopInput != "exit") && (Menu.stranded == false));
                // Game over
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Game Over!! Total years played: {0}yrs.  Total credits earned: {1}.", Math.Round(V.time, 2), V.totalCredits - 10000);
                Console.ReadLine();

            }
            #endregion
        }
    }
}
