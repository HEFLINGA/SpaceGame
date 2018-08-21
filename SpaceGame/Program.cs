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
            Console.WriteLine("the year is 3018.A guy a guy or girl of your choice relative passed and left them 10000 dollars. Their family use to be rich merchants but " +
                "feel on hard time.They always had a dream of becoming a space ship captain to try to restore their family's name and wealth. ");

            // Character selection
            Console.WriteLine("Enter your name: ");
            character = Console.ReadLine();

            Console.WriteLine("Welcome {0}!!", character);
            Console.ReadKey();
        }
    }
}
