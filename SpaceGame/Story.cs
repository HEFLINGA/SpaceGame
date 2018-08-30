using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Story
    {
        public void Intro()
        {
            #region StoryStartUp
            Console.WriteLine("Enter your name, Captian: ");
            V.character = Console.ReadLine();

            // Intro line and story
            Program.UI();
            Console.WriteLine("Welcome to Space Game!!");
            Console.WriteLine();
            Console.WriteLine($"  The year is 0AR. A relative passed and left you, {V.character}, 10,000 credits. Your family used to be rich merchants, but " +
                "fell on hard times... You have just finished flight school, and have always had a dream of becoming a space ship captain. So, you " +
                "decided to try your luck at that life to restore your family's name and wealth. The First stop! A cheap, Space Ship sales shop.");
            Console.WriteLine("Press 'Enter' to continue");
            Console.ReadLine();

            // Console  
            Program.UI();
            Console.WriteLine("You arrive at the cheapest space ship sales barn you could.. Real Fake Ships.. Definitely not your first choice, " +
                "But it's the only place on this planet you can find with a ship that's in your budget.");
            Console.WriteLine("");
            Console.WriteLine("You look around the room, trying to find anything below the price of 10,000 credits. Looking high and low, you " +
                "discover that even here at Real Fake Ships, the choices are slim to none!");
            Console.WriteLine("");
            Console.WriteLine("Then you see it!! Behind a cracked Real Fake Door, a ship with a price tag in your budget.. the tag says \"5,000 " +
                "credits.No Warrenty. Buy at own risk.\"");
            Console.WriteLine("");
            Console.WriteLine($"Click enter to walk up to the risky looking ship you spotted.. {Ship.ShowShipName(Ship.currentShip)}. and take its tag to the " +
                $"check out counter: ");
            Console.WriteLine("");
            Console.ReadLine();

            Program.UI();
            Console.WriteLine($"The cashier sees you walking up from the dark corner where they keep {Ship.ShowShipName(Ship.currentShip)}, and begins to laugh. " +
                $"as soon as you reach the counter, they asked if you knew what you were getting yourself into with that ship (the oldest ship " +
                $"currently on the market).");
            Console.WriteLine("");
            Console.WriteLine("You reply with the truth, and let them know that you really don't have any other options. They try to control " +
                "the laughter as they ring you up.");
            Console.WriteLine("");
            Console.WriteLine("Click 'enter' to continue");
            Console.ReadLine();
            Console.WriteLine($"You should be warned, {V.character}, this is a space game! You will be exploring the Galaxy, using fuel, buying and " +
                $"selling resources and trying to get the next upgrade to your ship to get to further and further planets!! If you are not careful.. " +
                $"you could easily run out of fuel on a random planet without any money or fuel left to get to a closer planet.. And that planet might " +
                $"even by the 'Screaming Sun Planet'.. It seems nice at first, until the damn sun comes up. This game will not hold your hand! Watch your " +
                $"fuel, and dont run out of money and get stranded! (I suggest just sticking to a travel route between 'Alpha Centauri' and 'Earth' for the " +
                $"first few good sales).");
            Console.WriteLine("");
            Console.WriteLine("Anyways!! Good luck out there. You wont be hearing from me again. I got better things to do then explain things and hold " +
                "your hand. You chose this life, don't blame me.");
            Console.WriteLine("");
            Console.WriteLine("Click 'enter' to continue");
            Console.ReadLine();
            Console.WriteLine("Type 'Buy' to complete the transaction, and start your amazing journey of wealth, family and adventure!!");
            #endregion
        }
    }
}
