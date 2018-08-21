using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Program
    {
        public static void Screen(int cargoCurrent, int cargoMax, string name, int credits)
        {
            int shipCargoCurrent = 0;
            int shipCargoMax = 4;
            string character = "";

            
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
        }

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

            // movement variables
            int charMoveLeftRight = 10;
            int charMoveUpDown = 10;


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
        }
    }
}
