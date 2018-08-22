using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Program
    {
        public static bool GameOver(double money, double time)
        {
            bool gameOver = false;
            if ((money >= 0) || (time >= 40))
            {
                gameOver = true;
            }
            else
            {
                gameOver = false;
            }

            return gameOver;
        }

        public static double TimePassage(double distance)
        {
            double totalTime = 40;
            double time = 0;
            bool timeOut = false;

            if (time >= totalTime)
            {
                
            }
            
        }

        static void Main(string[] args)
        {
            // string decleration
            string input;
            string shopInput;


            // int decleration
            int shipCargoMax = 0;
            int shipCargoCurrent = 0;
            int cost = 0;
            int credits = 10000;
            int gameOver = 0;

            // double decleration
            double speed = 0;
            double time = 0;

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

            // Cargo instantiation            

            Cargo food = new Cargo
            {
                Type = "Food",
                Size = 1,
                Cost = 2000,
                Speed = -.5
            };

            Cargo research = new Cargo
            {
                Type = "Research",
                Size = 1,
                Cost = 3000,
                Speed = -.5
            };

            Cargo animal = new Cargo
            {
                Type = "Animal",
                Size = 1,
                Cost = 4000,
                Speed = -.5
            };

            Cargo water = new Cargo
            {
                Type = "Water",
                Size = 2,
                Cost = 5000,
                Speed = -1
            };

            Cargo fuel = new Cargo
            {
                Type = "Fuel",
                Size = 2,
                Cost = 6000,
                Speed = -1
            };

            // Planet Instantiation

            Planet myPlanet = new Planet
            {
                Type = "EARTH",
                Date = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                Cost = 1.00
            };

            Planet myPlanet2 = new Planet
            {
                Type = "TRAPPIST-1",
                Date = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss" + 6),
                Cost = (1.00 - 0.86) / 0.86 * 100.00
            };


            Planet myPlanet3 = new Planet
            {
                Type = "ALPHA CENTAURI",
                Date = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss" + 8.5),
                Cost = (1.00 - 3.79) / 3.709 * 100.00
            };


            //Planet instantiation
            Planet myPlanet = new Planet();
            myPlanet.Type = "EARTH";
            myPlanet.Date = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            myPlanet.Cost = 1.00;

            Planet myPlanet2 = new Planet();
            myPlanet2.Type = "TRAPPIST-1";
            myPlanet2.Date = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss" + 6);
            myPlanet2.Cost = (1.00 - 0.86) / 0.86 * 100.00;

            Planet myPlanet3 = new Planet();
            myPlanet3.Type = "ALPHA CENTAURI";
            myPlanet3.Date = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss" + 8.5);
            myPlanet3.Cost = (1.00 - 3.79) / 3.709 * 100.00;



            // Intro line and story
            Console.WriteLine("Welcome to SpaceGame!!");
            Console.WriteLine();
            Console.WriteLine("  The year is 3018.A guy a guy or girl of your choice relative passed and left them 10000 dollars. Their family use to be rich merchants but " +
                "feel on hard time.They always had a dream of becoming a space ship captain to try to restore their family's name and wealth. ");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Enter your name, adventurer!");
            string character = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Welcome {0}, to the SPACE GAAMMMEEEEE(Click 'Enter' to continue)", character);
            Console.ReadLine();

            // Console
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.SetCursorPosition(40, 1);
            Console.WriteLine("Cargo: {0}/{1}", shipCargoCurrent, shipCargoMax);
            Console.SetCursorPosition(5, 1);
            Console.WriteLine("Name: {0}", character);
            Console.SetCursorPosition(80, 1);
            Console.WriteLine("Credits: {0}", credits);
            Console.WriteLine("________________________________________________________________________________________________________________________");

            // Buy your ship
            // TODO - Add ships description and price
            Console.Clear();
            // Console
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.SetCursorPosition(40, 1);
            Console.WriteLine("Cargo: {0}/{1}", shipCargoCurrent, shipCargoMax);
            Console.SetCursorPosition(5, 1);
            Console.WriteLine("Name: {0}", character);
            Console.SetCursorPosition(80, 1);
            Console.WriteLine("Credits: {0}", credits);
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.WriteLine("Buy your first ship! Type \"Purchase\" to complete the transaction: ");

            // Get input from console to select ship and purchase
            // TODO - Connect money and currancy to prices of ships
            // TODO - Connect ships to cases
            input = Console.ReadLine();

            switch (input)
            {
                case "Purchase":
                case "1":
                case "purchase":
                    cost = 5000;
                    credits -= tier1.Price;
                    shipCargoMax = tier1.Cargo;
                    speed = tier1.Speed;
                    break;
                default:
                    Console.Write("Well, it was nice knowin' you! Your days on a ship have ended before they began..");

                    break;
            }

            if (cost != 0)
            {
                Console.WriteLine("You paid {0} for your ship!!", cost);
                Console.WriteLine();
                Console.WriteLine("Thank you for shopping with SpaceBuggies R Us");
            }

            Console.Clear();
            Console.WriteLine("\n Your first ship!! The {0}. Speed: {1}. Cargo Space: {2}", tier1.Name, tier1.Speed, tier1.Cargo);
            Console.ReadLine();
            Console.Clear();

            // Player starts his journey exploring and buying

                while (GameOver(credits, time))
                {
                // Console
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.SetCursorPosition(40, 1);
                Console.WriteLine("Cargo: {0}/{1}", shipCargoCurrent, shipCargoMax);
                Console.SetCursorPosition(5, 1);
                Console.WriteLine("Name: {0}", character);
                Console.SetCursorPosition(80, 1);
                Console.WriteLine("Credits: {0}", credits);
                Console.WriteLine("________________________________________________________________________________________________________________________");

                //Console.WriteLine("You are on planet {0}! Currency is the {1}, current date/time is {2}. Earth has a {3} focused economy!", , , ,);
                Console.WriteLine("You are on planet Earth! Currency is the USD, current date/time is 3019/14:31. Earth has a Research focused economy!");
                Console.WriteLine();
                Console.WriteLine("What would you like to do?: (Type 'Upgrade' to upgrade your ship, 'Buy' to buy goods, 'Sell' to sell goods, or travel to leave and go to the next planet!)");

                // Planetary options
                shopInput = Console.ReadLine();
                    if (shopInput == "Buy")
                    {
                        Console.WriteLine("What would you like to buy?");
                        Console.WriteLine("{0}, price: {1}", food.Type, Math.Abs(food.Cost));
                        Console.WriteLine("{0}, price: {1}", research.Type, Math.Abs(research.Cost));
                        Console.WriteLine("{0}, price: {1}", animal.Type, Math.Abs(animal.Cost));
                        Console.WriteLine("{0}, price: {1}", water.Type, Math.Abs(water.Cost));
                        Console.WriteLine("{0}, price: {1}", fuel.Type, Math.Abs(fuel.Cost));
                        Console.ReadLine();
                        switch (shopInput)
                        {
                        case "Food":
                        case "food":
                            Console.Clear();
                            credits -= food.Cost;
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine("________________________________________________________________________________________________________________________");
                            Console.SetCursorPosition(40, 1);
                            Console.WriteLine("Cargo: {0}/{1}", shipCargoCurrent, shipCargoMax);
                            Console.SetCursorPosition(5, 1);
                            Console.WriteLine("Name: {0}", character);
                            Console.SetCursorPosition(80, 1);
                            Console.WriteLine("Credits: {0}", credits);
                            Console.WriteLine("________________________________________________________________________________________________________________________");
                            Console.WriteLine("");
                            Console.ReadLine();
                            break;
                        case "Research":
                        case "research":
                            Console.Clear();
                            credits -= research.Cost;
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine("________________________________________________________________________________________________________________________");
                            Console.SetCursorPosition(40, 1);
                            Console.WriteLine("Cargo: {0}/{1}", shipCargoCurrent, shipCargoMax);
                            Console.SetCursorPosition(5, 1);
                            Console.WriteLine("Name: {0}", character);
                            Console.SetCursorPosition(80, 1);
                            Console.WriteLine("Credits: {0}", credits);
                            Console.WriteLine("________________________________________________________________________________________________________________________");
                            Console.WriteLine("");
                            Console.ReadLine();
                            break;
                        case "animal":
                        case "Animal":
                            Console.Clear();
                            credits -= research.Cost;
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine("________________________________________________________________________________________________________________________");
                            Console.SetCursorPosition(40, 1);
                            Console.WriteLine("Cargo: {0}/{1}", shipCargoCurrent, shipCargoMax);
                            Console.SetCursorPosition(5, 1);
                            Console.WriteLine("Name: {0}", character);
                            Console.SetCursorPosition(80, 1);
                            Console.WriteLine("Credits: {0}", credits);
                            Console.WriteLine("________________________________________________________________________________________________________________________");
                            Console.WriteLine("");
                            Console.ReadLine();
                            break;

                    }
                    }
                }

                // Game over
                Console.WriteLine("Game Over!! Total play time: {0}.  Total credits: {1}", DateTime.Today, credits);
                Console.ReadLine();
            
        }
    }
}
