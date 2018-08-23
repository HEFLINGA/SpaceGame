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
        public static int cost = 0;
        public static int credits = 10000;
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
        public static bool GameOver(double money, double time)
        {
            bool gameOver = false;
            if ((money <= 0) || (time >= 40))
            {
                gameOver = true;
            }
            else
            {
                gameOver = false;
            }

            return gameOver;
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
            Console.WriteLine("  The year is 3018. A relative passed and left you 10,000 credits. Your family use to be rich merchants, but " +
                "fell on hard times. You always had a dream of becoming a space ship captain, so you decided to try your luck at that life to" +
                " restore your family's name and wealth.");
            Console.WriteLine("Press 'Enter' to continue");
            Console.ReadLine();

            // string decleration
            string input;
            string shopInput;

            // Cargo instantiation            
            #region Instantiating classes 

            Cargo food = new Cargo();
            food.Type = "Food";
            food.Size = 1;
            food.Cost = 2000;
            food.Speed = -.5;
            

            Cargo research = new Cargo();
            research.Type = "Research";
            research.Size = 1;
            research.Cost = 3000;
            research.Speed = -.5;

            // Ship instantiation
            Ship tier1 = new Ship();
            tier1.Name = "RustBucket";
            tier1.Speed = 3;
            tier1.Price = 5000;
            tier1.Cargo = 2;

            Ship tier2 = new Ship();
            tier2.Name = "Speedyy";
            tier2.Speed = 4;
            tier2.Price = 15000;
            tier2.Cargo = 4;

            Ship tier3 = new Ship();
            tier3.Name = "USS Schwifty Ship";
            tier3.Speed = 6;
            tier3.Price = 30000;
            tier3.Cargo = 6;

            Cargo animal = new Cargo();
            animal.Type = "Animal";
            animal.Size = 1;
            animal.Cost = 4000;
            animal.Speed = -.5;
            
            Cargo water = new Cargo();
            water.Type = "Water";
            water.Size = 2;
            water.Cost = 5000;
            water.Speed = -1;
            
            Cargo fuel = new Cargo();
            fuel.Type = "Fuel";
            fuel.Size = 2;
            fuel.Cost = 6000;
            fuel.Speed = -1;

            // Planet Instantiation

            Planet myPlanet = new Planet();
            myPlanet.Type = "EARTH";
            myPlanet.Date = time;
            myPlanet.Rate = 1.00;
            myPlanet.LocationX = 0;
            myPlanet.LocationY = 0;

            Planet myPlanet2 = new Planet();
            myPlanet2.Type = "TRAPPIST-1";
            myPlanet2.Date = time;
            myPlanet2.Rate = (1.00 - 0.86) / 0.86 * 100.00;
            myPlanet2.LocationX = 1;
            myPlanet2.LocationY = 3;


            Planet myPlanet3 = new Planet();
            myPlanet3.Type = "ALPHA CENTAURI";
            myPlanet3.Date = time;
            myPlanet3.Rate = (1.00 - 3.79) / 3.709 * 100.00;
            myPlanet3.LocationX = 0;
            myPlanet3.LocationY = 4.67;
            #endregion

            // strings
            string currentLocation = myPlanet.Type;

            Console.Clear();
            Console.WriteLine("Enter your name, adventurer!");
            character = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Welcome {0}, to the SPACE GAAMMMEEEEE", character);
            System.Threading.Thread.Sleep(2000);

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
                    Console.WriteLine("You are on planet {0}! Currency is the USD, current year is {1}!",
                        myPlanet.Type, myPlanet.Date);
                    Console.WriteLine();
                    Console.WriteLine("What would you like to do?: \n" +
                        "- 'Upgrade' to upgrade your ship\n" +
                        "- 'Buy' to buy goods\n" +
                        "- 'Sell' to sell goods\n" +
                        "- travel to leave and go to the next planet!)");

                    // Planetary options
                    shopInput = Console.ReadLine();
                    //Console.ReadLine();

                    if ((shopInput != "travel") || (shopInput != "Travel"))
                    {
                        if ((shopInput == "Buy") || (shopInput == "buy"))
                        {
                            Console.WriteLine("What would you like to buy?: \n" +
                                "(Type name of Item to purchase)");
                            Console.WriteLine("press 'Enter' to leave the trading post");
                            Console.WriteLine("{0}, price: {1}", food.Type, (food.Cost));
                            Console.WriteLine("{0}, price: {1}", research.Type, (research.Cost));
                            Console.WriteLine("{0}, price: {1}", animal.Type, (animal.Cost));
                            Console.WriteLine("{0}, price: {1}", water.Type, (water.Cost));
                            Console.WriteLine("{0}, price: {1}", fuel.Type, (fuel.Cost));

                            string buyInput = Console.ReadLine();
                            switch (buyInput)
                            {
                                case "Food":
                                case "food":
                                    Console.Clear();
                                    credits -= food.Cost;
                                    UI();
                                    break;
                                case "Research":
                                case "research":
                                    Console.Clear();
                                    credits -= research.Cost;
                                    UI();
                                    break;
                                case "animal":
                                case "Animal":
                                    Console.Clear();
                                    credits -= research.Cost;
                                    UI();
                                    break;
                                case "water":
                                case "Water":
                                    Console.Clear();
                                    credits -= water.Cost;
                                    UI();
                                    break;
                                case "fuel":
                                case "Fuel":
                                    Console.Clear();
                                    credits -= fuel.Cost;
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

                } while (GameOver(credits, time) == false);
                // Game over
                Console.WriteLine("Game Over!! Total play time: {0}.  Total credits: {1}", time, credits);
                Console.ReadLine();
            }
        }
    }
}
