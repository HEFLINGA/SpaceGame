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
            // Variable decleration
            string character;
            string ship1 = "1";
            string ship2 = "2";
            string ship3 = "3";
            string input;
            int cost = 0;


            // Character selection
            Console.WriteLine("Enter your name: ");
            character = Console.ReadLine();

            Console.WriteLine("Welcome {0} to, THE SPACE GAAMMMEEEEE", character);

            // Intro story
            // TODO - Add character name to story where names are said ----
            Console.WriteLine("Story");
            Console.ReadLine();

            // Buy your ship
            // TODO - Add ships description and price
            Console.WriteLine("Buy your first ship! Use the 1, 2 and 3 key to select your option: ");

            // Get input from console to select ship
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
        }
    }
}
