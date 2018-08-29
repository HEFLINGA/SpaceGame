using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Program
    {        
        // Congrats Window when buying ship
        public static void Congrats()
        {
            UI();
            Console.WriteLine("Congratulations on your new ship!!!!!");
            Console.WriteLine("You now have a new max V.speed and cargo!");
            Console.WriteLine();
            Console.WriteLine("New Max V.speed: {0}.  New Max Cargo: {1}", V.speed, V.maxInventory);
            Console.ReadLine();
        }
        // Random Number generator
        public static void RandomNumbers()
        {
            V.costFood = V.rnd.Next(2000, 3000);
            V.costResearch = V.rnd.Next(1000, 5000);
            V.costAnimals = V.rnd.Next(2000, 4000);
            V.costWater = V.rnd.Next(1000, 8000);
            V.costFuel = V.rnd.Next(2000, 7000);
        }
        // Code for Planets
        public static int Planet(int earth, int alphaCentauri, int trappist, int krootabulon)
        {
            if (V.currentPlanet == earth)
            {
                V.planetName = "Earth";
                V.x = 0;
                V.y = 0;
                RandomNumbers();
            }
            else if (V.currentPlanet == alphaCentauri)
            {
                V.planetName = "Alpha Centauri";
                V.x = 0;
                V.y = 4.367;
                RandomNumbers();
    }
            else if (V.currentPlanet == trappist)
            {
                V.planetName = "TRAPPIST-1";
                V.x = -2;
                V.y = 6;
                RandomNumbers();
            }
            else if (V.currentPlanet == krootabulon)
            {
                V.planetName = "Krootabulon!";
                V.x = 3;
                V.y = -7;
                RandomNumbers();
            }

            return V.currentPlanet;
        }
        // Code for inventory handling
        public static int Inventory(int maxInventory, int curInventory)
        {
            // remaining inventory space
            V.remInventory = maxInventory - curInventory;
            if (curInventory > 0)
            {
                Console.WriteLine("You have {0} Food", V.invFood);
                Console.WriteLine("You have {0} Research", V.invResearch);
                Console.WriteLine("You have {0} Animals", V.invAnimals);
                Console.WriteLine("You have {0} Water", V.invWater);
                Console.WriteLine("You have {0} Fuel", V.invFuel);
                Console.WriteLine("You have {0} out of {1} spaces remaining", V.remInventory, maxInventory);
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
            }
            else if (curInventory == 0)
            {
                Console.WriteLine("Your inventory is empty!");
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
            }

            return curInventory;
        }
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
        // Code for UI
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
        }
        // Code with game over bool
        public static bool GameOver(int credits, double time)
        {
            bool gameOver = false;
            if ((credits < 0) || (V.time >= 40.0))
            {
                gameOver = true;
            }
            else
            {
                gameOver = false;
            }

            return gameOver;
        }
        // Ship Menu for buying ships
        class Upgrade
        {
            // Ship options
            public static int StarExplorer()
            {
                if ((V.currentShip != V.tier2Ship) && (V.credits >= 20000))
                {
                    V.credits -= 20000;
                    V.currentShip = V.tier2Ship;
                    Ship(V.tier1Ship, V.tier2Ship, V.tier3Ship);
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
            public static int UssSchwiftiestShip()
            {
                if ((V.currentShip != V.tier3Ship) && (V.credits >= 50000))
                {
                    V.credits -= 50000;
                    V.currentShip = V.tier3Ship;
                    Ship(V.tier1Ship, V.tier2Ship, V.tier3Ship);
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
              
                    UI();

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
                            UI();
                            break;
                        case "USS Schwiftiest Ship":
                        case "uss schwiftiest ship":
                            Console.Clear();
                            UssSchwiftiestShip();
                            UI();
                            break;
                        default:
                            Console.WriteLine("Returning to Menu");
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            break;

                    }          
            }
        }
        // Buying Menu for buying resources
        class Buy
        {
            // Code for buying food
            public static int CargoFood()
            {
                if ((V.curInventory < V.maxInventory) && (V.credits >= V.costFood))
                {
                    V.credits -= V.costFood;
                    V.invFood += 1;
                }
                else if (V.credits <= V.costFood)
                {
                    UI();
                    Console.WriteLine("You do not have enough Credits to purchase item!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }
                else if ((V.remInventory == 0) || (V.curInventory == V.maxInventory))
                {
                    UI();
                    Console.WriteLine("You do not have enough space in your inventory!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return V.invFood;
            }
            // Code for buying research
            public static int CargoResearch()
            {
                if ((V.curInventory < V.maxInventory) && (V.credits >= V.costResearch))
                {
                    V.credits -= V.costResearch;
                    V.invResearch += 1;
                }
                else if (V.credits <= V.costResearch)
                {
                    UI();
                    Console.WriteLine("You do not have enough Credits to purchase item!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }
                else if ((V.remInventory == 0) || (V.curInventory == V.maxInventory))
                {
                    UI();
                    Console.WriteLine("You do not have enough space in your inventory!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return V.invResearch;
            }
            // Code for buying animals
            public static int CargoAnimals()
            {
                if ((V.curInventory < V.maxInventory) && (V.credits >= V.costAnimals))
                {
                    V.credits -= V.costAnimals;
                    V.invAnimals += 1;
                }
                else if (V.credits <= V.costAnimals)
                {
                    UI();
                    Console.WriteLine("You do not have enough Credits to purchase item!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }
                else if ((V.remInventory == 0) || (V.curInventory == V.maxInventory))
                {
                    UI();
                    Console.WriteLine("You do not have enough space in your inventory!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return V.invAnimals;
            }
            // Code for buying water
            public static int CargoWater()
            {
                if ((V.remInventory >= 2) && (V.credits >= V.costWater))
                {
                    V.credits -= V.costWater;
                    V.invWater += 2;
                }
                else if (V.credits <= V.costWater)
                {
                    UI();
                    Console.WriteLine("You do not have enough Credits to purchase item!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }
                else if (V.remInventory <= 1)
                {
                    UI();
                    Console.WriteLine("You do not have enough space in your inventory!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return V.invWater;
            }
            // Code for buying fuel (Resource)
            public static int CargoFuel()
            {
                if ((V.remInventory >= 2) && (V.credits >= V.costFuel))
                {
                    V.credits -= V.costFuel;
                    V.invFuel += 2;
                }
                else if (V.credits <= V.costFuel)
                {
                    UI();
                    Console.WriteLine("You do not have enough Credits to purchase item!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }
                else if (V.remInventory <= 1)
                {
                    UI();
                    Console.WriteLine("You do not have enough space in your inventory!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return V.invFuel;
            }
            // Buying Menu
            public static void BuyMenu()
            {
                string buyInput = "";

                do
                {
                    UI();
                    Inventory(V.maxInventory, V.curInventory);
                    UI();

                    Console.WriteLine("What would you like to buy?: \n" +
                                        "(Type name of Item to purchase)");
                    Console.WriteLine("press 'Enter' to leave the trading post");
                    Console.WriteLine();
                    Console.WriteLine($"Food, price: {V.costFood}. This will take up 1 cargo slot");
                    Console.WriteLine($"Research, price: {V.costResearch}. This will take up 1 cargo slot");
                    Console.WriteLine($"Animals, price: {V.costAnimals}. This will take up 1 cargo slot");
                    Console.WriteLine($"Water, price: {V.costWater}. This will take up 2 cargo slots");
                    Console.WriteLine($"Fuel, price: {V.costFuel}. This will take up 2 cargo slots");

                    buyInput = Console.ReadLine();
                    switch (buyInput)
                    {
                        case "Food":
                        case "food":
                            Console.Clear();
                            CargoFood();
                            UI();
                            break;
                        case "Research":
                        case "research":
                            Console.Clear();
                            CargoResearch();
                            UI();
                            break;
                        case "animals":
                        case "Animals":
                            Console.Clear();
                            CargoAnimals();
                            UI();
                            break;
                        case "water":
                        case "Water":
                            Console.Clear();
                            CargoWater();
                            UI();
                            break;
                        case "fuel":
                        case "Fuel":
                            Console.Clear();
                            CargoFuel();
                            UI();
                            break;
                        case "":
                            Console.WriteLine("Returning to Menu");
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            break;
                    }
                } while (buyInput != "");
            }
        }
        // Selling Menu for selling resources
        class Sell
        {
            public static int CargoFood()
            {
                if (V.invFood >= 1)
                {
                    V.credits += V.costFood;
                    V.totalCredits += V.costFood;
                    V.invFood -= 1;
                }
                else if (V.invFood == 0)
                {
                    UI();
                    Console.WriteLine("You do not have any Food in your inventory to sell!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return V.invFood;
            }
            public static int CargoResearch()
            {
                if (V.invResearch >= 1)
                {
                    V.credits += V.costResearch;
                    V.totalCredits += V.costResearch;
                    V.invResearch -= 1;
                }
                else if (V.invResearch == 0)
                {
                    UI();
                    Console.WriteLine("You do not have any Research Items in your inventory to sell!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return V.invResearch;
            }
            public static int CargoAnimals()
            {
                if (V.invAnimals >= 1)
                {
                    V.credits += V.costAnimals;
                    V.totalCredits += V.costAnimals;
                    V.invAnimals -= 1;
                }
                else if (V.invAnimals == 0)
                {
                    UI();
                    Console.WriteLine("You do not have any Animals in your inventory to sell!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return V.invAnimals;
            }
            public static int CargoWater()
            {
                if (V.invWater >= 2)
                {
                    V.credits += V.costWater;
                    V.totalCredits += V.costWater;
                    V.invWater -= 2;
                }
                else if (V.invWater < 2)
                {
                    UI();
                    Console.WriteLine("You do not have any Water in your inventory to sell!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return V.invWater;
            }
            public static int CargoFuel()
            {
                if (V.invFuel >= 2)
                {
                    V.credits += V.costFuel;
                    V.totalCredits += V.costFuel;
                    V.invFuel -= 2;
                }
                else if (V.invFuel < 2)
                {
                    UI();
                    Console.WriteLine("You do not have any Fuel in your inventory to Sell!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return V.invFuel;
            }

            public static void SellMenu()
            {
                string sellInput = "";
               
                do
                {
                    UI();
                    Inventory(V.maxInventory, V.curInventory);
                    UI();

                    Console.WriteLine("What would you like to Sell?: \n" +
                                        "(Type name of Item to purchase)");
                    Console.WriteLine("press 'Enter' to leave the trading post");
                    Console.WriteLine();
                    Console.WriteLine($"Food, sale price: {V.costFood}");
                    Console.WriteLine($"Research, sale price: {V.costResearch}");
                    Console.WriteLine($"Animals, sale price: {V.costAnimals}");
                    Console.WriteLine($"Water, sale price: {V.costWater}");
                    Console.WriteLine($"Fuel, sale price: {V.costFuel}");

                    sellInput = Console.ReadLine();
                    switch (sellInput)
                    {
                        case "Food":
                        case "food":
                            Console.Clear();
                            CargoFood();
                            UI();
                            break;
                        case "Research":
                        case "research":
                            Console.Clear();
                            CargoResearch();
                            UI();
                            break;
                        case "animals":
                        case "Animals":
                            Console.Clear();
                            CargoAnimals();
                            UI();
                            break;
                        case "water":
                        case "Water":
                            Console.Clear();
                            CargoWater();
                            UI();
                            break;
                        case "fuel":
                        case "Fuel":
                            Console.Clear();
                            CargoFuel();
                            UI();
                            break;
                        case "":
                            Console.WriteLine("Returning to Menu");
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            break;

                    }
                } while (sellInput != "");
            }
        }
        // Travelling Menu for traveling from world to world
        class Travel
        {            
            public static int Earth()
            {
                UI();
                if (V.currentPlanet == V.earth)
                {
                    Console.WriteLine("You are already here!! No need to travel anywhere..");
                    Console.WriteLine("Press 'enter' to return to Menu");
                    Console.ReadLine();
                }
                else if (V.currentPlanet != V.earth)
                {
                    V.destX = 0;
                    V.destY = 0;
                    Console.WriteLine("Heading to Earth!");
                    Console.WriteLine("Distance is: {0}LYs", Math.Round(Distance(V.x, V.y, V.destX, V.destY), 3));
                    Console.WriteLine("It will take you: {0}yrs", V.timePassage = Math.Round(Distance(V.x, V.y, V.destX, V.destY) / Velocity(V.speed), 2));
                    Console.WriteLine();
                    Console.WriteLine("type 'GO' to depart");
                    Console.WriteLine("press 'enter' to go back to main menu");
                    string conf = Console.ReadLine();

                    if (conf == "GO")
                    {
                        V.currentPlanet = V.earth;
                        V.time += V.timePassage;
                        Planet(V.earth, V.alphaCentauri, V.trappist, V.krootabulon);
                    }
                    else
                    {
                        Console.WriteLine("Returning to Menu");
                        System.Threading.Thread.Sleep(1100);
                    }

                }

                return V.currentPlanet;
            }

            public static int AlphaCentauri()
            {
                UI();
                if (V.currentPlanet == V.alphaCentauri)
                {
                    Console.WriteLine("You are already here!! No need to travel anywhere..");
                    Console.WriteLine("Press 'enter' to return to Menu");
                    Console.ReadLine();
                }
                else if (V.currentPlanet != V.alphaCentauri)
                {
                    V.destX = 0;
                    V.destY = 4.367;
                    Console.WriteLine("Heading to Alpha Centauri!");
                    Console.WriteLine("Distance is: {0}LYs", Math.Round(Distance(V.x, V.y, V.destX, V.destY), 3));
                    Console.WriteLine("It will take you: {0}yrs", V.timePassage = Math.Round(Distance(V.x, V.y, V.destX, V.destY) / Velocity(V.speed), 2));
                    Console.WriteLine();
                    Console.WriteLine("type 'GO' to depart");
                    Console.WriteLine("press 'enter' to go back to main menu");
                    string conf = Console.ReadLine();

                    if (conf == "GO")
                    {
                        V.currentPlanet = V.alphaCentauri;
                        V.time += V.timePassage;
                        Planet(V.earth, V.alphaCentauri, V.trappist, V.krootabulon);
                    }
                    else
                    {
                        Console.WriteLine("Returning to Menu");
                        System.Threading.Thread.Sleep(1100);
                    }

                }

                return V.currentPlanet;
            }

            public static int Trappist()
            {
                UI();
                if (V.currentPlanet == V.trappist)
                {
                    Console.WriteLine("You are already here!! No need to travel anywhere..");
                    Console.WriteLine("Press 'enter' to return to Menu");
                    Console.ReadLine();
                }
                else if (V.currentPlanet != V.trappist)
                {
                    V.destX = -2;
                    V.destY = 6;
                    Console.WriteLine("Heading to TRAPPIST-1!");
                    Console.WriteLine("Distance is: {0}LYs", Math.Round(Distance(V.x, V.y, V.destX, V.destY), 3));
                    Console.WriteLine("It will take you: {0}yrs", V.timePassage = Math.Round(Distance(V.x, V.y, V.destX, V.destY) / Velocity(V.speed), 2));
                    Console.WriteLine();
                    Console.WriteLine("type 'GO' to depart");
                    Console.WriteLine("press 'enter' to go back to main menu");
                    string conf = Console.ReadLine();

                    if (conf == "GO")
                    {
                        V.currentPlanet = V.trappist;
                        V.time += V.timePassage;
                        Planet(V.earth, V.alphaCentauri, V.trappist, V.krootabulon);
                    }
                    else
                    {
                        Console.WriteLine("Returning to Menu");
                        System.Threading.Thread.Sleep(1100);
                    }
                }

                return V.currentPlanet;
            }

            public static int Krootabulon()
            {
                UI();
                if (V.currentPlanet == V.krootabulon)
                {
                    Console.WriteLine("You are already here!! No need to travel anywhere..");
                    Console.WriteLine("Press 'enter' to return to Menu");
                    Console.ReadLine();
                }
                else if (V.currentPlanet != V.krootabulon)
                {
                    V.destX = 3;
                    V.destY = -7;
                    Console.WriteLine("Heading to Krootabulon!");
                    Console.WriteLine("Distance is: {0}LYs", Math.Round(Distance(V.x, V.y, V.destX, V.destY), 3));
                    Console.WriteLine("It will take you: {0}yrs", V.timePassage = Math.Round(Distance(V.x, V.y, V.destX, V.destY) / Velocity(V.speed), 2));
                    Console.WriteLine();
                    Console.WriteLine("type 'GO' to depart");
                    Console.WriteLine("press 'enter' to go back to main menu");
                    string conf = Console.ReadLine();

                    if (conf == "GO")
                    {
                        V.currentPlanet = V.krootabulon;
                        V.time += V.timePassage;
                        Planet(V.earth, V.alphaCentauri, V.trappist, V.krootabulon);
                    }
                    else
                    {
                        Console.WriteLine("Returning to Menu");
                        System.Threading.Thread.Sleep(1100);
                    }

                }

                return V.currentPlanet;
            }

            public static void TravelMenu()
            {
                string travelInput = "";

                UI();

                Console.WriteLine("Where would you like to go!!: \n" +
                                    "(Type name of planet you wish to go to)");
                Console.WriteLine("press 'Enter' to leave the space port and return to Main Menu");
                Console.WriteLine("- 'Earth' for Earth!");
                Console.WriteLine("- 'Alpha Centauri' for Alpha Centauri!");
                Console.WriteLine("- 'Trappist' for TRAPPIST-1");
                Console.WriteLine("- 'Kroot' for krootabulon!!");


                travelInput = Console.ReadLine();
                switch (travelInput)
                {
                    case "Earth":
                    case "earth":
                        Console.Clear();
                        Earth();
                        UI();
                        break;
                    case "Alpha Centauri":
                    case "alpha centauri":
                        Console.Clear();
                        AlphaCentauri();
                        UI();
                        break;
                    case "Trappist":
                    case "trappist":
                    case "TRAPPIST":
                        Console.Clear();
                        Trappist();                        
                        UI();
                        break;
                    case "Krootabulon":
                    case "krootabulon":
                    case "kroot":
                    case "Kroot":
                        Console.Clear();
                        Krootabulon();
                        UI();
                        break;
                    default:    
                        Console.WriteLine("Returning to Menu");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        break;

                }
            }
        }
        // Math for distance
        public static double Distance(double x1, double y1, double destX, double destY)
        {
            V.distance = Math.Sqrt(Math.Pow((V.destX - x1), 2) + Math.Pow((destY - y1), 2));

            return V.distance;
        }
        // Math for Velocity
        public static double Velocity(double speed)
        {
            V.velocity = Math.Pow(V.speed, (10/3)) + Math.Pow((10 - V.speed), -11/3);

            return V.velocity;
        }
        // Main Game
        public static void Main(string[] args)
        {
            V.currentShip = V.tier1Ship;
            Ship(V.tier1Ship, V.tier2Ship, V.tier3Ship);
            V.currentPlanet = V.earth;
            Planet(V.earth, V.alphaCentauri, V.trappist, V.krootabulon);

            // string decleration
            string input;
            string shopInput;

            // Stroy Start up
            Story.Intro();

            // Get input from console to select ship and purchase
            input = Console.ReadLine();

            // buying first ship
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
                    Console.WriteLine("You are on planet {0}! Current year is {1}!", V.planetName, Math.Round(V.time, 2));
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
                    //Console.ReadLine();

                    if ((shopInput != "exit") || (shopInput != "Exit"))
                    {
                        if ((shopInput == "Ship") || (shopInput == "ship"))
                        {
                            Upgrade.ShipMenu();
                        }
                        else if ((shopInput == "Buy") || (shopInput == "buy"))
                        {
                            Buy.BuyMenu();
                        }
                        else if ((shopInput == "Sell") || (shopInput == "sell"))
                        {
                            Sell.SellMenu();
                        }
                        else if ((shopInput == "Inv") || (shopInput == "inv"))
                        {
                            Inventory(V.maxInventory, V.curInventory);
                        }
                        else if ((shopInput == "Travel") || (shopInput == "travel"))
                        {
                            Travel.TravelMenu();
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
