using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Program
    {
        // TODO - 

        // Decleration of variables

        #region Public Variable Decleration
        public static Random rnd = new Random();

        // Inventory and item variables
        public static int curInventory = 0;
        public static int maxInventory = 0;
        public static int remInventory = 0;
        public static int invFood = 0;
        public static int invResearch = 0;
        public static int invAnimals = 0;
        public static int invWater = 0;
        public static int invFuel = 0;
        public static int cost = 0;
        public static int price = 0;
        public static int credits = 10000;
        public static int totalCredits = 0;
        public static int costFood = 2000;
        public static int costResearch = 3000;
        public static int costAnimals = 4000;
        public static int costWater = 5000;
        public static int costFuel = 6000;

        //various variables
        public static double timePassage = 0;
        public static double time = 0;
        public static double speed = 0;
        public static double distance = 0;
        public static string character = "";

        // ship variables
        public static string shipName = "";
        public static int currentShip = 0;
        public static int shipPrice = 0;
        public static int tier1Ship = 1;
        public static int tier2Ship = 2;
        public static int tier3Ship = 3;

        // Planets and travel variables
        public static string planetName = "";
        public static int currentPlanet = 0;
        public static int earth = 1;
        public static int alphaCentauri = 2;
        public static int trappist = 3;
        public static double x = 0;
        public static double y = 0;
        public static double destX = 0;
        public static double destY = 0;
        public static double velocity = 0;        
        #endregion

        // Congrats Window when buying ship
        public static void Congrats()
        {
            UI();
            Console.WriteLine("Congratulations on your new ship!!!!!");
            Console.WriteLine("You now have a new max speed and cargo!");
            Console.WriteLine();
            Console.WriteLine("New Max Speed: {0}.  New Max Cargo: {1}", speed, maxInventory);
            Console.ReadLine();
        }
        // Random Number generator
        public static void RandomNumbers()
        {
            costFood = rnd.Next(2000, 3000);
            costResearch = rnd.Next(1000, 5000);
            costAnimals = rnd.Next(2000, 4000);
            costWater = rnd.Next(1000, 8000);
            costFuel = rnd.Next(2000, 7000);
        }
        // Code for Planets
        public static int Planet(int earth, int alphaCentauri, int trappist)
        {
            if (currentPlanet == earth)
            {
                planetName = "Earth";
                x = 0;
                y = 0;
                RandomNumbers();
            }
            else if (currentPlanet == alphaCentauri)
            {
                planetName = "Alpha Centauri";
                x = 0;
                y = 4.367;
                RandomNumbers();
    }
            else if (currentPlanet == trappist)
            {
                planetName = "TRAPPIST-1";
                x = -2;
                y = 6;
                RandomNumbers();
            }

            return currentPlanet;
        }
        // Code for inventory handling
        public static int Inventory(int maxInventory, int curInventory)
        {
            // remaining inventory space
            remInventory = maxInventory - curInventory;
            if (curInventory > 0)
            {
                Console.WriteLine("You have {0} Food", invFood);
                Console.WriteLine("You have {0} Research", invResearch);
                Console.WriteLine("You have {0} Animals", invAnimals);
                Console.WriteLine("You have {0} Water", invWater);
                Console.WriteLine("You have {0} Fuel", invFuel);
                Console.WriteLine("You have {0} out of {1} spaces remaining", remInventory, maxInventory);
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
            if (currentShip == tier1Ship)
            {
                shipName = "Space Cruiser";
                maxInventory = 3;
                speed = 1.5;
                shipPrice = 5000;
                velocity = Velocity(speed);
            }
            else if (currentShip == tier2Ship)
            {
                shipName = "Star Explorer";
                maxInventory = 5;
                speed = 3;
                shipPrice = 20000;
                velocity = Velocity(speed);
            }
            else if (currentShip == tier3Ship)
            {
                shipName = "USS Schwiftiest Ship";
                maxInventory = 10;
                speed = 6;
                shipPrice = 50000;
                velocity = Velocity(speed);
            }

            return currentShip;
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
            Console.WriteLine("Cargo: {0}/{1}", curInventory = invFood + invResearch + invAnimals + invWater + invFuel, maxInventory);
            Console.SetCursorPosition(5, 1);
            Console.WriteLine("Name: {0}", character);
            Console.SetCursorPosition(55, 1);
            Console.WriteLine("Credits: {0}", credits);
            Console.SetCursorPosition(90, 1);
            Console.WriteLine("Year: {0}", time);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }
        // Code with game over bool
        public static bool GameOver(int credits, double time)
        {
            totalCredits = (credits += credits);
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
        // Ship Menu for buying ships
        class Upgrade
        {
            // Ship options
            public static int StarExplorer()
            {
                if ((currentShip != tier2Ship) && (credits >= 20000))
                {
                    credits -= 20000;
                    currentShip = tier2Ship;
                    Ship(tier1Ship, tier2Ship, tier3Ship);
                    Congrats();
                }
                else if (currentShip == tier2Ship)
                {
                    Console.WriteLine($"You already own that ship! No need to have 2 of them.. you are but one person {character}");
                    Console.WriteLine("Press Enter to return to Main Menu");
                    Console.ReadLine();
                }
                else if (credits < 20000)
                {
                    Console.WriteLine("You are to broke to afford such a ship.. Get more credits and come back");
                    Console.WriteLine("Press Enter to return to Main Menu");
                    Console.ReadLine();
                }

                return currentShip;
            }
            public static int UssSchwiftiestShip()
            {
                if ((currentShip != tier3Ship) && (credits >= 50000))
                {
                    credits -= 50000;
                    currentShip = tier3Ship;
                    Ship(tier1Ship, tier2Ship, tier3Ship);
                    Congrats();
                }
                else if (currentShip == tier3Ship)
                {
                    Console.WriteLine($"You already own that ship! No need to have 2 of them.. you are but one person {character}");
                    Console.WriteLine("Press Enter to return to Main Menu");
                    Console.ReadLine();
                }
                else if (credits < 50000)
                {
                    Console.WriteLine("You are to broke to afford such a ship.. Get more credits and come back");
                    Console.WriteLine("Press Enter to return to Main Menu");
                    Console.ReadLine();
                }

                return currentShip;
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
                    Console.WriteLine("Star Explorer! Price: 20000 credits. Speed: 3. Cargo: 5");
                    Console.WriteLine("USS Schwiftiest Ship! Price: 50000 credits. Speed: 6. Cargo: 10");

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
                if ((curInventory < maxInventory) && (credits >= costFood))
                {
                    credits -= costFood;
                    invFood += 1;
                }
                else if (credits <= costFood)
                {
                    UI();
                    Console.WriteLine("You do not have enough Credits to purchase item!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }
                else if ((remInventory == 0) || (curInventory == maxInventory))
                {
                    UI();
                    Console.WriteLine("You do not have enough space in your inventory!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return invFood;
            }
            // Code for buying research
            public static int CargoResearch()
            {
                if ((curInventory < maxInventory) && (credits >= costResearch))
                {
                    credits -= costResearch;
                    invResearch += 1;
                }
                else if (credits <= costResearch)
                {
                    UI();
                    Console.WriteLine("You do not have enough Credits to purchase item!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }
                else if ((remInventory == 0) || (curInventory == maxInventory))
                {
                    UI();
                    Console.WriteLine("You do not have enough space in your inventory!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return invResearch;
            }
            // Code for buying animals
            public static int CargoAnimals()
            {
                if ((curInventory < maxInventory) && (credits >= costAnimals))
                {
                    credits -= costAnimals;
                    invAnimals += 1;
                }
                else if (credits <= costAnimals)
                {
                    UI();
                    Console.WriteLine("You do not have enough Credits to purchase item!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }
                else if ((remInventory == 0) || (curInventory == maxInventory))
                {
                    UI();
                    Console.WriteLine("You do not have enough space in your inventory!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return invAnimals;
            }
            // Code for buying water
            public static int CargoWater()
            {
                if ((remInventory >= 2) && (credits >= costWater))
                {
                    credits -= costWater;
                    invWater += 2;
                }
                else if (credits <= costWater)
                {
                    UI();
                    Console.WriteLine("You do not have enough Credits to purchase item!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }
                else if (remInventory <= 1)
                {
                    UI();
                    Console.WriteLine("You do not have enough space in your inventory!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return invWater;
            }
            // Code for buying fuel (Resource)
            public static int CargoFuel()
            {
                if ((remInventory >= 2) && (credits >= costFuel))
                {
                    credits -= costFuel;
                    invFuel += 2;
                }
                else if (credits <= costFuel)
                {
                    UI();
                    Console.WriteLine("You do not have enough Credits to purchase item!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }
                else if (remInventory <= 1)
                {
                    UI();
                    Console.WriteLine("You do not have enough space in your inventory!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return invFuel;
            }
            // Buying Menu
            public static void BuyMenu()
            {
                string buyInput = "";

                do
                {
                    UI();
                    Inventory(maxInventory, curInventory);
                    UI();

                    Console.WriteLine("What would you like to buy?: \n" +
                                        "(Type name of Item to purchase)");
                    Console.WriteLine("press 'Enter' to leave the trading post");
                    Console.WriteLine();
                    Console.WriteLine($"Food, price: {costFood}. This will take up 1 cargo slot");
                    Console.WriteLine($"Research, price: {costResearch}. This will take up 1 cargo slot");
                    Console.WriteLine($"Animals, price: {costAnimals}. This will take up 1 cargo slot");
                    Console.WriteLine($"Water, price: {costWater}. This will take up 2 cargo slots");
                    Console.WriteLine($"Fuel, price: {costFuel}. This will take up 2 cargo slots");

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
                if (invFood >= 1)
                {
                    credits += costFood;
                    invFood -= 1;
                }
                else if (invFood == 0)
                {
                    UI();
                    Console.WriteLine("You do not have any Food in your inventory to sell!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return invFood;
            }
            public static int CargoResearch()
            {
                if (invResearch >= 1)
                {
                    credits += costResearch;
                    invResearch -= 1;
                }
                else if (invResearch == 0)
                {
                    UI();
                    Console.WriteLine("You do not have any Research Items in your inventory to sell!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return invResearch;
            }
            public static int CargoAnimals()
            {
                if (invAnimals >= 1)
                {
                    credits += costAnimals;
                    invAnimals -= 1;
                }
                else if (invAnimals == 0)
                {
                    UI();
                    Console.WriteLine("You do not have any Animals in your inventory to sell!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return invAnimals;
            }
            public static int CargoWater()
            {
                if (invWater >= 2)
                {
                    credits += costWater;
                    invWater -= 2;
                }
                else if (invWater < 2)
                {
                    UI();
                    Console.WriteLine("You do not have any Water in your inventory to sell!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return invWater;
            }
            public static int CargoFuel()
            {
                if (invFuel >= 2)
                {
                    credits += costFuel;
                    invFuel -= 2;
                }
                else if (invFuel < 2)
                {
                    UI();
                    Console.WriteLine("You do not have any Fuel in your inventory to Sell!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return invFuel;
            }

            public static void SellMenu()
            {
                string sellInput = "";
               
                do
                {
                    UI();
                    Inventory(maxInventory, curInventory);
                    UI();

                    Console.WriteLine("What would you like to Sell?: \n" +
                                        "(Type name of Item to purchase)");
                    Console.WriteLine("press 'Enter' to leave the trading post");
                    Console.WriteLine();
                    Console.WriteLine($"Food, sale price: {costFood}");
                    Console.WriteLine($"Research, sale price: {costResearch}");
                    Console.WriteLine($"Animals, sale price: {costAnimals}");
                    Console.WriteLine($"Water, sale price: {costWater}");
                    Console.WriteLine($"Fuel, sale price: {costFuel}");

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
                if (currentPlanet == earth)
                {
                    Console.WriteLine("You are already here!! No need to travel anywhere..");
                    Console.WriteLine("Press 'enter' to return to Menu");
                    Console.ReadLine();
                }
                else if (currentPlanet != earth)
                {
                    destX = 0;
                    destY = 0;
                    Console.WriteLine("Heading to Earth!");
                    Console.WriteLine("Distance is: {0}LYs", Math.Round(Distance(x, y, destX, destY), 3));
                    Console.WriteLine("It will take you: {0}yrs", timePassage = Math.Round(Distance(x, y, destX, destY) / Velocity(speed), 2));
                    Console.WriteLine("Press 'enter' to launch");
                    Console.ReadLine();

                    currentPlanet = earth;
                    time += timePassage;
                    Planet(earth, alphaCentauri, trappist);
                }

                return currentPlanet;
            }

            public static int AlphaCentauri()
            {
                if (currentPlanet == alphaCentauri)
                {
                    Console.WriteLine("You are already here!! No need to travel anywhere..");
                    Console.WriteLine("Press 'enter' to return to Menu");
                    Console.ReadLine();
                }
                else if (currentPlanet != alphaCentauri)
                {
                    destX = 0;
                    destY = 4.367;
                    Console.WriteLine("Heading to Alpha Centauri!");
                    Console.WriteLine("Distance is: {0}LYs", Math.Round(Distance(x, y, destX, destY), 3));
                    Console.WriteLine("It will take you: {0}yrs", timePassage = Math.Round(Distance(x, y, destX, destY) / Velocity(speed), 2));
                    Console.WriteLine("Press 'enter' to launch");
                    Console.ReadLine();

                    currentPlanet = alphaCentauri;
                    time += timePassage;
                    Planet(earth, alphaCentauri, trappist);
                }

                return currentPlanet;
            }

            public static int Trappist()
            {
                if (currentPlanet == trappist)
                {
                    Console.WriteLine("You are already here!! No need to travel anywhere..");
                    Console.WriteLine("Press 'enter' to return to Menu");
                    Console.ReadLine();
                }
                else if (currentPlanet != trappist)
                {
                    destX = -2;
                    destY = 6;
                    Console.WriteLine("Heading to TRAPPIST-1!");
                    Console.WriteLine("Distance is: {0}LYs", Math.Round(Distance(x, y, destX, destY), 3));
                    Console.WriteLine("It will take you: {0}yrs", timePassage = Math.Round(Distance(x, y, destX, destY) / Velocity(speed), 2));
                    Console.WriteLine("Press 'enter' to launch");
                    Console.ReadLine();

                    currentPlanet = trappist;
                    time += timePassage;
                    Planet(earth, alphaCentauri, trappist);
                }

                return currentPlanet;
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
            return Math.Sqrt(Math.Pow((destX - x), 2) + Math.Pow((destY - y), 2));
        }
        // Math for Velocity
        public static double Velocity(double speed)
        {
            velocity = Math.Pow(speed, (10/3)) + Math.Pow((10 - speed), -11/3);

            return velocity;
        }
        // Main Game
        public static void Main(string[] args)
        {
            currentShip = tier1Ship;
            Ship(tier1Ship, tier2Ship, tier3Ship);
            currentPlanet = earth;
            Planet(earth, alphaCentauri, trappist);

            // string decleration
            string input;
            string shopInput;

            #region StoryStartUp
            Console.WriteLine("Enter your name, Captian: ");
            character = Console.ReadLine();

            // Intro line and story
            Console.Clear();
            Console.WriteLine("Welcome to Space Game!!");
            Console.WriteLine();
            Console.WriteLine($"  The year is 0AR. A relative passed and left you, {character}, 10,000 credits. Your family used to be rich merchants, but " +
                "fell on hard times... You have just finished flight school, and have always had a dream of becoming a space ship captain. So, you " +
                "decided to try your luck at that life to restore your family's name and wealth. The First stop! A cheap, Space Ship sales shop.");
            Console.WriteLine("Press 'Enter' to continue");
            Console.ReadLine();
            Console.Clear();

            // Console            
            Console.WriteLine("You arrive at the cheapest space ship sales barn you could.. Real Fake Ships.. Definitely not your first choice, " +
                "But it's the only place on this planet you can find with a ship that's in your budget.");
            Console.WriteLine("");
            Console.WriteLine("You look around the room, trying to find anything below the price of 10,000 credits. Looking high and low, you " +
                "discover that even here at Real Fake Ships, the choices are slim to none!");
            Console.WriteLine("");
            Console.WriteLine("Then you see it!! Behind a cracked Real Fake Door, a ship with a price tag in your budget.. the tag says \"5,000 " +
                "credits.No Warrenty. Buy at own risk.\"");
            Console.WriteLine("");
            Console.WriteLine($"Click enter to walk up to the risky looking ship you spotted.. {shipName}. and take its tag to the " +
                $"check out counter: ");
            Console.WriteLine("");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"The cashier sees you walking up from the dark corner where they keep {shipName}, and begins to laugh. " +
                $"as soon as you reach the counter, they asked if you knew what you were getting yourself into with that ship (the oldest ship " +
                $"currently on the market).");
            Console.WriteLine("");
            Console.WriteLine("You reply with the truth, and let them know that you really don't have any other options. They try to control " +
                "the laughter as they ring you up.");
            Console.WriteLine("");
            Console.WriteLine("Click 'enter' to continue");
            Console.ReadLine();
            Console.WriteLine("Type 'Buy' to complete the transaction, and start your amazing journey of wealth, family and adventure!!");
            #endregion

            // Get input from console to select ship and purchase
            input = Console.ReadLine();

            // buying first ship
            switch (input)
            {
                case "Buy":
                case "buy":
                    cost = 5000;
                    credits -= shipPrice;
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
                UI();
                Console.WriteLine("You paid {0} for your ship!!", cost);
                Console.WriteLine();
                Console.WriteLine("Thank you for shopping with SpaceBuggies R Us");
                System.Threading.Thread.Sleep(1200);

                UI();
                Console.WriteLine("\n Your first ship!! The {0}. Speed: {1}. Cargo Space: {2}", shipName, speed, maxInventory);
                Console.ReadLine();

                // Player starts his journey exploring and buying

                do
                {
                    // Console/Menu
                    UI();
                    Console.WriteLine("You are on planet {0}! Current year is {1}!", planetName, Math.Round(time, 2));
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
                            Inventory(maxInventory, curInventory);
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

                } while ((GameOver(credits, time) == false) && (shopInput != "exit"));
                // Game over
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Game Over!! Total play time: {0}.  Total credits earned: {1}.", Math.Round(time, 2), totalCredits - 10000);
                Console.ReadLine();

            }
            #endregion
        }
    }
}
