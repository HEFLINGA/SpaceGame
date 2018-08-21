using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Ship
    {

        // Speed


        // Constructor that takes no arguments:
        public static double Speed()
        {
            double warpFactor = Math.Pow(3, (10 / 3)) + Math.Pow((10 - 3), -11 / 3) ;
            double volocity = warpFactor;            

            return warpFactor;
        }

        // Constructor that takes one argument:
        public static int Cargo(int cargo)
        {
            return cargo;
        }

        // TODO - upgrades
        public static void Upgrades()
        {

        }

        // Method that overrides the base class (System.Object) implementation.
        public override string ToString()
        {
            return Name;
        }
    }
}
