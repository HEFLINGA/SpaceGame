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
            string currentPlanet;
            string input;


            // int decleration
            int shipMaxSpeed = 3;
            int shipCargoMax = 4;
            int shipCargoCurrent = 0;            
            int cost = 0;  
            int credits = 10000;
            int gameOver = 0;

            // Intro line and story
            Console.WriteLine("Welcome to SpaceGame!!");
            Console.WriteLine("the year is 3018.A guy a guy or girl of your choice relative passed and left them 10000 dollars. Their family use to be rich merchants but " +
                "feel on hard time.They always had a dream of becoming a space ship captain to try to restore their family's name and wealth. ");

            // Console.SetCursorPosition(2, 3);
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

            // Intro story
            // TODO - Add character name to story where names are said ----
            Console.WriteLine("Story");
            Console.ReadLine();

            // Buy your ship
            // TODO - Add ships description and price
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
                    break;
                default:
                    Console.Write("Well, it was nice knowin' you! Your days on a ship have ended before they began..");
                    
                    break;
            }

            if (cost != 0)
            {
                Console.WriteLine("You paid {0} for your ship!!", cost);
            }
            Console.WriteLine("Thank you for shopping with SpaceBuggies R Us");
            Console.WriteLine();
            Console.WriteLine("{0} {1} {2}", tier1.Name, tier1.Speed, tier1.Cargo);
            Console.ReadLine();

            Console.Clear();

            // Player starts his journey exploring and buying
            credits = 5000;

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



            // Ship instantiation
            Ship tier1 = new Ship();
            tier1.Name = "RustBucket";
            tier1.Speed = 3;
            tier1.Cargo = 2;

            Ship tier2 = new Ship();
            tier2.Name = "Speedyy";
            tier2.Speed = 4;
            tier2.Cargo = 4;

            Ship tier3 = new Ship();
            tier3.Name = "USS Schwifty Ship";
            tier3.Speed = 6;
            tier3.Cargo = 6;

            Console.WriteLine("{0} {1} {2}", tier1.Name, tier1.Speed, tier1.Cargo);
            



        }
    }
}
