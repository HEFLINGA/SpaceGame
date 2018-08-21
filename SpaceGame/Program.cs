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

            // Intro line and story
            Console.WriteLine("Welcome to SpaceGame!!");
            Console.WriteLine("Story");

            // Character selection
            Console.WriteLine("Enter your name: ");
            character = Console.ReadLine();

            Console.WriteLine("Welcome {0}!!", character);
        }
    }
}
