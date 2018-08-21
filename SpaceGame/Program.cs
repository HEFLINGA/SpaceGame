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
            string character = "John Doe";
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

            do
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

                // Movement
                ConsoleKeyInfo KeyInfo;
                KeyInfo = Console.ReadKey(true);
                switch (KeyInfo.Key)
                {
                    case ConsoleKey.RightArrow:
                        charMoveLeftRight++;
                        Console.SetCursorPosition(charMoveLeftRight, charMoveUpDown);
                        Console.Write("X");
                        break;
                }

            } while (gameOver == 0);


            Console.SetCursorPosition(2, 3);
            Console.WriteLine("Welcome {0} to, THE SPACE GAAMMMEEEEE", character);

            // Intro story
            // TODO - Add character name to story where names are said ----
            Console.WriteLine("Story");
            Console.ReadLine();

            // Buy your ship
            // TODO - Add ships description and price
            Console.WriteLine("Buy your first ship! Use the 1, 2 and 3 key to select your option: ");

            // Get input from console to select ship and purchase
            // TODO - Connect money and currancy to prices of ships
            // TODO - Connect ships to cases
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    cost = 5000;
                    break;
                case "2":
                    cost = 15000;
                    break;
                case "3":
                    cost = 30000;
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please choose between the 3 ships using 1, 2 and 3");
                    break;
            }

            if (cost != 0)
            {
                Console.WriteLine("You paid {0} for your ship!!", cost);
            }
            Console.WriteLine("Thank you for shopping with SpaceBuggies R Us");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
