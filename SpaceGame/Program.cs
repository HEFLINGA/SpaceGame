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

            input = Console.ReadLine();

            if (input == ship1)
            {
                Console.WriteLine("Ship 1 bought");
            }
            else if (input == ship2)
            {
                Console.WriteLine("Ship 2 bought");
            }
            else if (input == ship3)
            {
                Console.WriteLine("Ship 3 bought");
            }
            else
            {
                Console.WriteLine("No Valid input");
            }

        }
    }
}
