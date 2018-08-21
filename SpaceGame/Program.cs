using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Program
    {
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

            // double decleration
            double speed = 0;

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

            // Cargo instantiation
            Cargo myCargo = new Cargo();
            myCargo.Type = "Food";
            myCargo.Size = 1;
            myCargo.Cost = -2000;
            myCargo.Speed = -.5;

            Cargo myCargo2 = new Cargo();
            myCargo2.Type = "Research";
            myCargo2.Size = 1;
            myCargo2.Cost = -3000;
            myCargo.Speed = -.5;

            Cargo myCargo3 = new Cargo();
            myCargo3.Type = "Animal";
            myCargo3.Size = 1;
            myCargo3.Cost = -4000;
            myCargo.Speed = -.5;

            Cargo myCargo4 = new Cargo();
            myCargo4.Type = "Water";
            myCargo4.Size = 2;
            myCargo4.Cost = -5000;
            myCargo.Speed = -1;

            Cargo myCargo5 = new Cargo();
            myCargo5.Type = "Fuel";
            myCargo5.Size = 2;
            myCargo5.Cost = -6000;
            myCargo.Speed = speed -= 1;


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

            Console.WriteLine("\n Your first ship!! The {0}. Speed: {1}. Cargo Space: {2}", tier1.Name, tier1.Speed, tier1.Cargo);
            Console.ReadLine();

            Console.Clear();

            // Player starts his journey exploring and buying

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

            Console.ReadLine();

            //Console.WriteLine("You are on planet {0}! Currency is the {1}, current date/time is {2}. Earth has a {3} focused economy!", , , ,);
            Console.WriteLine("You are on planet Earth! Currency is the USD, current date/time is 3019/14:31. Earth has a Research focused economy!");
            Console.WriteLine();
            Console.WriteLine("What would you like to do?: (Type 'Upgrade' to upgrade your ship, 'Buy' to buy goods, 'Sell' to sell goods, or travel to leave and go to the next planet!)");

            // Planetary options
            shopInput = Console.ReadLine();
            switch (shopInput)
            {
                case "Buy":
                case "buy":
                    Console.Clear();
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("________________________________________________________________________________________________________________________");
                    Console.SetCursorPosition(40, 1);
                    Console.WriteLine("Cargo: {0}/{1}", shipCargoCurrent, shipCargoMax);
                    Console.SetCursorPosition(5, 1);
                    Console.WriteLine("Name: {0}", character);
                    Console.SetCursorPosition(80, 1);
                    Console.WriteLine("Credits: {0}", credits);
                    Console.WriteLine("________________________________________________________________________________________________________________________");
                    Console.WriteLine("What would you like to buy?: (Type name of item you want from list): ");
                    break;
                case "Sell":
                case "sell":
                    Console.Clear();
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("________________________________________________________________________________________________________________________");
                    Console.SetCursorPosition(40, 1);
                    Console.WriteLine("Cargo: {0}/{1}", shipCargoCurrent, shipCargoMax);
                    Console.SetCursorPosition(5, 1);
                    Console.WriteLine("Name: {0}", character);
                    Console.SetCursorPosition(80, 1);
                    Console.WriteLine("Credits: {0}", credits);
                    Console.WriteLine("________________________________________________________________________________________________________________________");
                    Console.WriteLine("What would you like to sell?: (Type name of item you want to sell from your Cargo");
                    break;
                case "Upgrade":
                case "upgrade":
                    Console.Clear();
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("________________________________________________________________________________________________________________________");
                    Console.SetCursorPosition(40, 1);
                    Console.WriteLine("Cargo: {0}/{1}", shipCargoCurrent, shipCargoMax);
                    Console.SetCursorPosition(5, 1);
                    Console.WriteLine("Name: {0}", character);
                    Console.SetCursorPosition(80, 1);
                    Console.WriteLine("Credits: {0}", credits);
                    Console.WriteLine("________________________________________________________________________________________________________________________");
                    Console.WriteLine("What upgrade would you like to buy? Speed: {0}, or Cargo{1}", tier1.Speed, tier1.Cargo);
                    break;
                default:
                    Console.Clear();
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("________________________________________________________________________________________________________________________");
                    Console.SetCursorPosition(40, 1);
                    Console.WriteLine("Cargo: {0}/{1}", shipCargoCurrent, shipCargoMax);
                    Console.SetCursorPosition(5, 1);
                    Console.WriteLine("Name: {0}", character);
                    Console.SetCursorPosition(80, 1);
                    Console.WriteLine("Credits: {0}", credits);
                    Console.WriteLine("________________________________________________________________________________________________________________________");
                    Console.WriteLine("Where would you like to go!: ");
                    break;
            }
        }
    }
}
