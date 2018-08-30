using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    public class Ship
    {
        // ship variables
        public string shipName = "";
        public static int currentShip = 0;
        public int shipPrice = 0;
        public double speed = 0;
        public static double curFuel = 0;
        public double maxFuel = 0;

        // Code for setting Ship
        public int Tier1Ship()
        {
            return currentShip = 1;
        }
        public int Tier2Ship()
        {
            return currentShip = 2;
        }
        public int Tier3Ship()
        {
            return currentShip = 3;
        }

        // Default constructor
        public Ship()
        {

        }

        public double ShipMaxFuel(double maxFuel)
        {
            this.maxFuel = maxFuel;
            return this.maxFuel;
        }

        // Code for setting ship name
        public string ShipName(string shipName)
        {
            this.shipName = shipName;
            return this.shipName;
        }

        // Code for setting ship cargo max
        public int ShipCargo(int maxInventory)
        {
            V.maxInventory = maxInventory;
            return V.maxInventory;
        }

        // Code for setting ship speed
        public double ShipSpeed(double speed)
        {
            this.speed = speed;
            return this.speed;
        }

        // Code for setting ship Velocity
        public double ShipVelocity(double speed)
        {
            Program.Velocity(speed);
            return Program.Velocity(speed);
        }

        // Code for showing stuff to user and for use later
        public static string ShowShipName(int currentShip)
        {
            if (currentShip == 1)
            {
                return "Space Cruiser";
            }
            else if (currentShip == 2)
            {
                return "Star Explorer";
            }
            else if (currentShip == 3)
            {
                return "USS Schwifty Ship";
            }

            return ShowShipName(currentShip);
        }
        public static double ShowShipSpeed(int currentShip)
        {
            if (currentShip == 1)
            {
                return 1.5;
            }
            else if (currentShip == 2)
            {
                return 3;
            }
            else if (currentShip == 3)
            {
                return 6;
            }

            return ShowShipSpeed(currentShip);
        }
        public static double ShowShipMaxFuel(int currentShip)
        {
            if (currentShip == 1)
            {
                return 10;
            }
            else if (currentShip == 2)
            {
                return 35;
            }
            else if (currentShip == 3)
            {
                return 60;
            }

            return ShowShipMaxFuel(currentShip);
        }
    }    
}
