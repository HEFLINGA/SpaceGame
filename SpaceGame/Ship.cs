using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Ship
    {

        public string Name { get; set; }
        public int Cargo { get; set; }
        public int Price { get; set; }
        public double Speed { get; set; }
        
        /*
        // Speed when ship has warp factor 3
        public static double Speed()
        {
            double warpFactor = Math.Pow(3, (10 / 3)) + Math.Pow((10 - 3), -11 / 3) ;
            double volocity = warpFactor;            

            return warpFactor;
        }        
        */
    }
}
