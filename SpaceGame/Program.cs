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
        public static int curInventory = 0;
        public static int maxInventory = 0;
        public static int remInventory = maxInventory - curInventory;
        public static int cost = 0;
        public static int price = 0;
        public static int credits = 10000;
        public static int costFood = 2000;
        public static int costResearch = 3000;
        public static int costAnimals = 4000;
        public static int costWater = 5000;
        public static int costFuel = 6000;
        public static double time = 0;
        public static double speed = 0;
        public static double distance = 0;
        public static string character = "";
        public static string currentShip = "";
        #endregion

        public static void UI()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.SetCursorPosition(30, 1);
            Console.WriteLine("Cargo: {0}/{1}", curInventory, maxInventory);
            Console.SetCursorPosition(5, 1);
            Console.WriteLine("Name: {0}", character);
            Console.SetCursorPosition(55, 1);
            Console.WriteLine("Credits: {0}", credits);
            Console.SetCursorPosition(90, 1);
            Console.WriteLine("Time: {0}", time);
            Console.WriteLine("________________________________________________________________________________________________________________________");
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
        public static int Inventory(int maxInventory, int curInventory)
        {
            // remaining inventory space
            remInventory = curInventory - maxInventory;

            if (curInventory < maxInventory)
            {
                Console.WriteLine("You have {0} items in your inventory", curInventory);
                Console.WriteLine("You have {0} space remaining", Math.Abs(remInventory));
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
            }
            else if (curInventory == maxInventory)
            {
                Console.WriteLine("Your inventory is full!");
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
            }

            return curInventory;
        }

        class Buy
        {
            public static int CargoFood()
            {
                int food = 1;

                if ((remInventory < maxInventory) && (credits >= 2000))
                {
                    credits -= costFood;
                    curInventory += food;
                }
                else if (remInventory == 0)
                {
                    UI();
                    Console.WriteLine("You do not have enough space in your inventory!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }
                else if (credits <= 2000)
                {
                    UI();
                    Console.WriteLine("You do not have enough Credits to purchase item!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return food;
            }
            public static int CargoResearch()
            {
                int research = 1;

                if ((remInventory < maxInventory) && (credits >= 3000))
                {
                    credits -= costResearch;
                    curInventory += research;
                }
                else if (remInventory == 0)
                {
                    UI();
                    Console.WriteLine("You do not have enough space in your inventory!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }
                else if (credits <= 3000)
                {
                    UI();
                    Console.WriteLine("You do not have enough Credits to purchase item!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return research;
            }
            public static int CargoAnimals()
            {
                int animals = 1;

                if ((remInventory < maxInventory) && (credits >= 4000))
                {
                    credits -= costAnimals;
                    curInventory += animals;
                }
                else if (remInventory == 0)
                {
                    UI();
                    Console.WriteLine("You do not have enough space in your inventory!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }
                else if (credits <= 4000)
                {
                    UI();
                    Console.WriteLine("You do not have enough Credits to purchase item!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return animals;
            }
            public static int CargoWater()
            {
                int water = 2;

                if ((remInventory <= 2) && (credits >= 5000))
                {
                    credits -= costWater;
                    curInventory += water;
                }
                else if (remInventory < 2)
                {
                    UI();
                    Console.WriteLine("You do not have enough space in your inventory!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }
                else if (credits <= 5000)
                {
                    UI();
                    Console.WriteLine("You do not have enough Credits to purchase item!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return water;
            }
            public static int CargoFuel()
            {
                int fuel = 2;

                if ((remInventory <= 2) && (credits >= 6000))
                {
                    credits -= costFuel;
                    curInventory += fuel;
                }
                else if (remInventory < 2)
                {
                    UI();
                    Console.WriteLine("You do not have enough space in your inventory!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }
                else if (credits <= 6000)
                {
                    UI();
                    Console.WriteLine("You do not have enough Credits to purchase item!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return fuel;
            }

            public static void BuyMenu()
            {
                string buyInput = "";

                UI();

                Console.WriteLine("What would you like to buy?: \n" +
                                    "(Type name of Item to purchase)");
                Console.WriteLine("press 'Enter' to leave the trading post");
                Console.WriteLine("Food, price: 2000");
                Console.WriteLine("Research, price: 3000");
                Console.WriteLine("Animals, price: 4000");
                Console.WriteLine("Water, price: 5000");
                Console.WriteLine("Fuel, price: 6000");

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
                int food = 1;

                if (curInventory > 0)
                {
                    credits += costFood;
                    curInventory -= food;
                }
                else if (curInventory == 0)
                {
                    UI();
                    Console.WriteLine("You do not have anything in your inventory!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return food;
            }
            public static int CargoResearch()
            {
                int research = 1;

                if (curInventory > 0)
                {
                    credits += costResearch;
                    curInventory -= research;
                }
                else if (curInventory == 0)
                {
                    UI();
                    Console.WriteLine("You do not have anything in your inventory!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return research;
            }
            public static int CargoAnimals()
            {
                int animals = 1;

                if (curInventory > 0)
                {
                    credits += costAnimals;
                    curInventory -= animals;
                }
                else if (curInventory == 0)
                {
                    UI();
                    Console.WriteLine("You do not have anything in your inventory!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return animals;
            }
            public static int CargoWater()
            {
                int water = 2;

                if (curInventory >= 2)
                {
                    credits += costWater;
                    curInventory -= water;
                }
                else if (curInventory < 2)
                {
                    UI();
                    Console.WriteLine("You do not have anything in your inventory!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return water;
            }
            public static int CargoFuel()
            {
                int fuel = 2;

                if (curInventory >= 2)
                {
                    credits += costFuel;
                    curInventory -= fuel;
                }
                else if (curInventory < 2)
                {
                    UI();
                    Console.WriteLine("You do not have anything in your inventory!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return fuel;
            }

            public static void SellMenu()
            {
                string buyInput = "";

                UI();

                Console.WriteLine("What would you like to Sell?: \n" +
                                    "(Type name of Item to purchase)");
                Console.WriteLine("press 'Enter' to leave the trading post");
                Console.WriteLine("Food, sale price: 2000");
                Console.WriteLine("Research, sale price: 3000");
                Console.WriteLine("Animals, sale price: 4000");
                Console.WriteLine("Water, sale price: 5000");
                Console.WriteLine("Fuel, sale price: 6000");

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

        static void Main(string[] args)
        {
            // Intro line and story
            Console.WriteLine("Welcome to SpaceGame!!");
            Console.WriteLine();
            Console.WriteLine("  The year is 3018. A relative passed and left you 10,000 credits. Your family used to be rich merchants, but " +
                "fell on hard times. You always had a dream of becoming a space ship captain, so you decided to try your luck at that life to" +
                " restore your family's name and wealth.");
            Console.WriteLine("Press 'Enter' to continue");
            Console.ReadLine();

            // string decleration
            string input;
            string shopInput;

            #region Instantiating classes            
           

            // Ship instantiation
            Ship tier1 = new Ship
            {
                Name = "RustBucket",
                Speed = 3,
                Price = 5000,
                Cargo = 2
            };

            Ship tier2 = new Ship
            {
                Name = "Speedyy",
                Speed = 4,
                Price = 15000,
                Cargo = 4
            };

            Ship tier3 = new Ship
            {
                Name = "USS Schwifty Ship",
                Speed = 6,
                Price = 30000,
                Cargo = 6
            };

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

            // strings
            string currentLocation = myPlanet.Type;

            Console.Clear();
            Console.WriteLine("Enter your name, Captian: ");
            character = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Welcome {0}, to the SPACE GAAMMMEEEEE", character);
            System.Threading.Thread.Sleep(1200);

            // Console
            UI();

            // Buy your ship
            // TODO - Add ships description and price
            Console.Clear();

            // Console
            UI();
            Console.WriteLine("Buy your first ship! Type 'Buy' to complete the transaction: ");

            // Get input from console to select ship and purchase
            // TODO - Connect money and currancy to prices of ships
            // TODO - Connect ships to cases

            input = Console.ReadLine();

            // buying first ship
            switch (input)
            {
                case "Buy":
                case "1":
                case "buy":
                    cost = 5000;
                    credits -= tier1.Price;
                    maxInventory = tier1.Cargo;
                    speed = tier1.Speed;
                    break;
                case "":
                    Console.WriteLine("Well, it was nice knowin' you! Your days on a ship have ended before they began..");
                    Console.WriteLine("Press enter to exit");
                    Console.ReadLine();
                    break;
            }

            if (cost != 0)
            {
                UI();
                Console.WriteLine("You paid {0} for your ship!!", cost);
                Console.WriteLine();
                Console.WriteLine("Thank you for shopping with SpaceBuggies R Us");
                System.Threading.Thread.Sleep(2500);

                UI();
                Console.WriteLine("\n Your first ship!! The {0}. Speed: {1}. Cargo Space: {2}", tier1.Name, tier1.Speed, tier1.Cargo);
                Console.ReadLine();

                // Player starts his journey exploring and buying

                do
                {
                    // Console
                    UI();

                    //Console.WriteLine("You are on planet {0}! Currency is the {1}, current date/time is {2}. Earth has a {3} focused economy!", , , ,);
                    Console.WriteLine("You are on planet {0}! Current year is {1}!", myPlanet.Type, myPlanet.Date);
                    Console.WriteLine();
                    Console.WriteLine("What would you like to do?: \n" +
                        "- 'Upgrade' to upgrade your ship\n" +
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
                        if ((shopInput == "Buy") || (shopInput == "buy"))
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
                Console.WriteLine("Game Over!! Total play time: {0}.  Total credits: {1}", time, credits - 10000);
                Console.ReadLine();

            }
        }
    }
}
