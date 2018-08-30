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

        // Code for fuel buying decisions
        public static double BuyingFuel()
        {
            string input = "";
            do
            {
                Program.UI();
                Console.WriteLine("How much Fuel would you like to buy?");
                Console.WriteLine("Fuel is sold in bundles of: ");
                Console.WriteLine("1. 1 - Fuel. Price: 250");
                Console.WriteLine("2. 5 - Fuel. Price: 1250");
                Console.WriteLine("3. 10 - Fuel. Price: 2500");
                Console.WriteLine("4. 15 - Fuel. Price: 3750");
                Console.WriteLine("5. 30 - Fuel. Price: 7500");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Press 'enter' to exit back to Menu!");
                input = Console.ReadLine().ToLower();

                if (input == "1")
                {
                    if ((V.credits >= 250) && (curFuel < ShowShipMaxFuel(currentShip)))
                    {
                        curFuel += 1;
                        V.credits -= 250;
                        Console.WriteLine("You bought 1 Fuel!");
                        Console.WriteLine("Loading..");
                        System.Threading.Thread.Sleep(800);
                    }
                    else if ((V.credits < 250) || (curFuel >= ShowShipMaxFuel(currentShip)))
                    {
                        Console.WriteLine("You can not purchase this item");
                        Console.WriteLine("Press 'enter' to continue");
                        Console.ReadLine();
                    }
                }
                else if (input == "2")
                {
                    if ((V.credits >= 1250) && (curFuel <= ShowShipMaxFuel(currentShip) - 5))
                    {
                        curFuel += 5;
                        V.credits -= 1250;
                        Console.WriteLine("You bought 5 Fuel!");
                        Console.WriteLine("Loading..");
                        System.Threading.Thread.Sleep(800);
                    }
                    else if ((V.credits < 1250) || (curFuel >= ShowShipMaxFuel(currentShip) - 4))
                    {
                        Console.WriteLine("You can not purchase this item");
                        Console.WriteLine("Press 'enter' to continue");
                        Console.ReadLine();
                    }

                }
                else if (input == "3")
                {
                    if ((V.credits >= 2500) && (curFuel <= ShowShipMaxFuel(currentShip) - 10))
                    {
                        curFuel += 10;
                        V.credits -= 2500;
                        Console.WriteLine("You bought 10 Fuel!");
                        Console.WriteLine("Loading..");
                        System.Threading.Thread.Sleep(800);
                    }
                    else if ((V.credits < 2500) || (curFuel >= ShowShipMaxFuel(currentShip) - 9))
                    {
                        Console.WriteLine("You can not purchase this item");
                        Console.WriteLine("Press 'enter' to continue");
                        Console.ReadLine();
                    }

                }
                else if (input == "4")
                {
                    if ((V.credits >= 3750) && (curFuel <= ShowShipMaxFuel(currentShip) - 15))
                    {
                        curFuel += 15;
                        V.credits -= 3750;
                        Console.WriteLine("You bought 15 Fuel!");
                        Console.WriteLine("Loading..");
                        System.Threading.Thread.Sleep(800);
                    }
                    else if ((V.credits < 3750) || (curFuel >= ShowShipMaxFuel(currentShip) - 14))
                    {
                        Console.WriteLine("You can not purchase this item");
                        Console.WriteLine("Press 'enter' to continue");
                        Console.ReadLine();
                    }
                }
                else if (input == "5")
                {
                    if ((V.credits >= 7500) && (curFuel <= ShowShipMaxFuel(currentShip) - 30))
                    {
                        curFuel += 30;
                        V.credits -= 7500;
                        Console.WriteLine("You bought 30 Fuel!");
                        Console.WriteLine("Loading..");
                        System.Threading.Thread.Sleep(800);
                    }
                    else if ((V.credits < 7500) || (curFuel >= ShowShipMaxFuel(currentShip) - 29))
                    {
                        Console.WriteLine("You can not purchase this item");
                        Console.WriteLine("Press 'enter' to continue");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.. Please check what you type before sendin' it in.");
                }
            } while (input != "");

            return curFuel;
        }

        // Code for getting Max Fuel
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
