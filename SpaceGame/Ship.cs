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

        internal static void tier1()
        {
            Ship tier1 = new Ship();
            tier1.Name = "RustBucket";
            tier1.Speed = 3;
            tier1.Price = 5000;
            tier1.Cargo = 2;
        }





        /*
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
        */
    }
}
