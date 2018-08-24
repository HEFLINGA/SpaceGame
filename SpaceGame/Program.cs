using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Program
    {
        #region Public Variable Decleration

        // Inventory and item variables
        public static int curInventory = 0;
        public static int maxInventory = 0;
        public static int remInventory = maxInventory - curInventory;
        public static int invFood = 0;
        public static int invResearch = 0;
        public static int invAnimals = 0;
        public static int invWater = 0;
        public static int invFuel = 0;
        public static int cost = 0;
        public static int price = 0;
        public static int credits = 10000;
        public static int costFood = 2000;
        public static int costResearch = 3000;
        public static int costAnimals = 4000;
        public static int costWater = 5000;
        public static int costFuel = 6000;

        //various variables
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
        #endregion

        public static int Ship(int tier1, int tier2, int tier3)
        {
            if (currentShip == tier1Ship)
            {
                shipName = "Space Cruiser";
                maxInventory = 2;
                speed = 3;
                shipPrice = 5000;
            }
            else if (currentShip == tier2Ship)
            {
                shipName = "Star Explorer";
                maxInventory = 4;
                speed = 4;
                shipPrice = 15000;
            }
            else if (currentShip == tier3Ship)
            {
                shipName = "USS Schwiftiest Ship";
                maxInventory = 6;
                speed = 6;
                shipPrice = 30000;
            }

            return currentShip;
        }

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
            Console.WriteLine("Time: {0}", time);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }
        public static bool GameOver(int credits, double time)
        {
            bool gameOver = false;
            if ((credits < 0) || (time >= 40))
            {
                gameOver = true;
            }
            else
            {
                gameOver = false;
            }

            return gameOver;
        }

        // Inventory space and cargo types   

        class Upgrade
        {
            public static void ShipMenu()
            {


                string shipMenuInput = "";

                UI();

                Console.WriteLine("What would you like to buy?: \n" +
                                        "(Type name of Ship to purchase)");
                Console.WriteLine("press 'Enter' to leave the trading post");
                Console.WriteLine("Star Exlorer, price: 15000 credits. Speed: 4. Cargo: 4");
                Console.WriteLine("USS Schwiftiest Ship, price: 30000 credits. Speed: 6. Cargo: 6");

                shipMenuInput = Console.ReadLine();
                switch (shipMenuInput)
                {
                    case "Star Explorer":
                    case "star explorer":
                        Console.Clear();
                        CargoFood();
                        UI();
                        break;
                    case "USS Schwiftiest Ship":
                    case "uss schwiftiest ship":
                        Console.Clear();
                        CargoResearch();
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

        class Buy
        {
            public static int CargoFood()
            {
                if ((remInventory < maxInventory) && (credits >= costFood))
                {
                    credits -= costFood;
                    invFood += 1;
                }
                else if (remInventory == 0)
                {
                    UI();
                    Console.WriteLine("You do not have enough space in your inventory!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }
                else if (credits <= costFood)
                {
                    UI();
                    Console.WriteLine("You do not have enough Credits to purchase item!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return invFood;
            }
            public static int CargoResearch()
            {
                if ((remInventory < maxInventory) && (credits >= costResearch))
                {
                    credits -= costResearch;
                    invResearch += 1;
                }
                else if (remInventory == 0)
                {
                    UI();
                    Console.WriteLine("You do not have enough space in your inventory!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }
                else if (credits <= costResearch)
                {
                    UI();
                    Console.WriteLine("You do not have enough Credits to purchase item!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return invResearch;
            }
            public static int CargoAnimals()
            {
                if ((remInventory < maxInventory) && (credits >= costAnimals))
                {
                    credits -= costAnimals;
                    invAnimals += 1;
                }
                else if (remInventory == 0)
                {
                    UI();
                    Console.WriteLine("You do not have enough space in your inventory!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }
                else if (credits <= costAnimals)
                {
                    UI();
                    Console.WriteLine("You do not have enough Credits to purchase item!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return invAnimals;
            }
            public static int CargoWater()
            {
                if ((remInventory <= 2) && (credits >= costWater))
                {
                    credits -= costWater;
                    invWater += 2;
                }
                else if (remInventory < 2)
                {
                    UI();
                    Console.WriteLine("You do not have enough space in your inventory!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }
                else if (credits <= costWater)
                {
                    UI();
                    Console.WriteLine("You do not have enough Credits to purchase item!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return invWater;
            }
            public static int CargoFuel()
            {
                if ((remInventory <= 2) && (credits >= costFuel))
                {
                    credits -= costFuel;
                    invFuel += 2;
                }
                else if (remInventory < 2)
                {
                    UI();
                    Console.WriteLine("You do not have enough space in your inventory!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }
                else if (credits <= costFuel)
                {
                    UI();
                    Console.WriteLine("You do not have enough Credits to purchase item!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return invFuel;
            }

            public static void BuyMenu()
            {
                string buyInput = "";

                UI();

                Console.WriteLine("What would you like to buy?: \n" +
                                    "(Type name of Item to purchase)");
                Console.WriteLine("press 'Enter' to leave the trading post");
                Console.WriteLine($"Food, price: {costFood}. This will take up 1 cargo slot");
                Console.WriteLine($"Research, price: {costResearch}. This will take up 1 cargo slot");
                Console.WriteLine($"Animals, price: {costAnimals}. This will take up 1 cargo slot");
                Console.WriteLine($"Water, price: {costWater}. This will take up 2 cargo slot");
                Console.WriteLine($"Fuel, price: {costFuel}. This will take up 2 cargo slot");

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
                    default:
                        Console.WriteLine("Returning to Menu");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        break;

                }
            }
        }

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
                string buyInput = "";

                UI();

                Console.WriteLine("What would you like to Sell?: \n" +
                                    "(Type name of Item to purchase)");
                Console.WriteLine("press 'Enter' to leave the trading post");
                Console.WriteLine($"Food, sale price: {costFood}");
                Console.WriteLine($"Research, sale price: {costResearch}");
                Console.WriteLine($"Animals, sale price: {costAnimals}");
                Console.WriteLine($"Water, sale price: {costWater}");
                Console.WriteLine($"Fuel, sale price: {costFuel}");

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
                    default:
                        Console.WriteLine("Returning to Menu");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        break;

                }
            }
        }

        public static int Inventory(int maxInventory, int curInventory)
        {
            // remaining inventory space
            remInventory = curInventory - maxInventory;
            if (curInventory > 0)
            {
                Console.WriteLine("You have {0} Food", invFood);
                Console.WriteLine("You have {0} Research", invResearch);
                Console.WriteLine("You have {0} Animals", invAnimals);
                Console.WriteLine("You have {0} Water", invWater);
                Console.WriteLine("You have {0} Fuel", invFuel);
                Console.WriteLine("You have {0} space remaining out of {1}", Math.Abs(remInventory), Math.Abs(maxInventory));
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

        /*
        public static double TimePassage(double distance)
        {
            double totalTime = 40;
            double currentTime = 0;

            while (currentTime < totalTime)
            {
                if (distance > 0)
                {
                    currentTime += distance;
                    return currentTime;
                }
            }            

            return currentTime;
        }
        */

        //public static double Distance(double LocationX, double LocationY)
        //{
        //double distance = 0;
        //distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        //return distance;

        //Calculate the distance between the both points
        //for both axes separately.
        //double curLocation = Math.Abs(LocationX - cordX);
        //double desLocation = Math.Abs(LocationY - cordY);

        //Calculate the length of a line traveling from pt1 to pt2
        //(according to Pythagoras).
        //double dblHypotenuseLength = Math.Sqrt(
        //   LocationX * dblDistX
        //   +
        //   LocationY * dblDistY);

        //   return dblHypotenuseLength;
        //}


        public static void Main(string[] args)
        {
            currentShip = tier1Ship;
            Ship(tier1Ship, tier2Ship, tier3Ship);
            #region Instantiating classes

            // Planet Instantiation

            Planet myPlanet = new Planet
            {
                Type = "EARTH",
                Date = time,
                Rate = 1.00,
                LocationX = 0,
                LocationY = 0
            };

            Planet myPlanet2 = new Planet
            {
                Type = "TRAPPIST-1",
                Date = time,
                Rate = (1.00 - 0.86) / 0.86 * 100.00,
                LocationX = 1,
                LocationY = 3
            };

            Planet myPlanet3 = new Planet
            {
                Type = "ALPHA CENTAURI",
                Date = time,
                Rate = (1.00 - 3.79) / 3.709 * 100.00,
                LocationX = 0,
                LocationY = 4.67
            };
            #endregion

            // string decleration
            string input;
            string shopInput;
            string currentLocation = myPlanet.Type;

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


            #region Game
            if (cost != 0)
            {
                UI();
                Console.WriteLine("You paid {0} for your ship!!", cost);
                Console.WriteLine();
                Console.WriteLine("Thank you for shopping with SpaceBuggies R Us");
                System.Threading.Thread.Sleep(2500);

                UI();
                Console.WriteLine("\n Your first ship!! The {0}. Speed: {1}. Cargo Space: {2}", shipName, speed, maxInventory);
                Console.ReadLine();

                // Player starts his journey exploring and buying

                do
                {
                    // Console
                    UI();
                    Console.WriteLine("You are on planet {0}! Current year is {1}!", myPlanet.Type, myPlanet.Date);
                    Console.WriteLine();
                    Console.WriteLine("What would you like to do?: \n" +
                        "- 'Ship' to upgrade your current ship or buy a new ship\n" +
                        "- 'Buy' to buy goods\n" +
                        "- 'Sell' to sell goods\n" +
                        "- 'travel' to leave and go to the next planet!\n" +
                        "- 'inv' to check your current inventory space\n" +
                        "- 'exit' to exit the game........");

                    // Planetary options
                    shopInput = Console.ReadLine();
                    //Console.ReadLine();

                    if ((shopInput != "travel") || (shopInput != "Travel"))
                    {
                        if ((shopInput == "Ship") || (shopInput == "ship"))
                        {

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
                        else if (shopInput == "exit")
                        {
                            break;
                        }
                    }

                } while ((GameOver(credits, time) == false) || (shopInput != "exit"));
                // Game over
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Game Over!! Total play time: {0}.  Total credits earned: {1}", time, credits - 10000);
                Console.ReadLine();

            }
            #endregion
        }
    }
}