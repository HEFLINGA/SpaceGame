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

            Console.WriteLine(Ship.Speed());


            // Character selection
            Console.WriteLine("Enter your name: ");
            character = Console.ReadLine();

            Console.WriteLine("Welcome {0}!!", character);
        }
    }
}
