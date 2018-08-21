using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Ship
    {

        // Speed when ship has warp factor 3
        public static double Speed()
        {
            double warpFactor = Math.Pow(3, (10 / 3)) + Math.Pow((10 - 3), -11 / 3) ;
            double volocity = warpFactor;            

            return warpFactor;
        }

        // Constructor that takes one argument:
        public static int Cargo(int cargo)
        {
            int baseCargo = 4;
            
            switch (cargo)
            {
                case 1:
                    Console.WriteLine("You have 4 slots remaining");
                    break;
                case 2:
                    Console.WriteLine("You have 3 slots remaining");
                    break;
                case 3:
                    Console.WriteLine("You have 2 slots remaining");
                    break;
            }
            return cargo;
        }

        // TODO - upgrades
        public static void Upgrades()
        {

        }
    }
}
