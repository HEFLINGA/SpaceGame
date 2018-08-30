using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    public class Planet
    {
        private double x = 0;
        private double y = 0;
        private double destX = 0;
        private double destY = 0;
        private string planetName = "";
        public static int currentPlanet;

        // Default constructor
        public Planet()
        {
        }

        // Methods for using planets
        public int PlanetEarth()
        {
            return currentPlanet = 1;
        }
        public int PlanetAlphaCentauri()
        {
            return currentPlanet = 2;
        }
        public int PlanetTrappist()
        {
            return currentPlanet = 3;
        }
        public int Planetkrootabulon()
        {
            return currentPlanet = 4;
        }

        // Get planet name
        public static string GetPlanetName(int currentPlanet)
        {
            if (currentPlanet == 1)
            {
                return new Planet().planetName = "Earth";
            }
            else if (currentPlanet == 2)
            {
                return new Planet().planetName = "Alpha Centauri";
            }
            else if (currentPlanet == 3)
            {
                return new Planet().planetName = "TRAPPIST-1";
            }
            else if (currentPlanet == 4)
            {
                return new Planet().planetName = "Krootabulon!";
            }
            return GetPlanetName(currentPlanet);

        }

        // Get planet X
        public static double GetCurX()
        {
            if (currentPlanet == 1)
            {
                return new Planet().x = 0;
            }
            if (currentPlanet == 2)
            {
                return new Planet().x = 0;
            }
            if (currentPlanet == 3)
            {
                return new Planet().x = -3;
            }
            if (currentPlanet == 4)
            {
                return new Planet().x = 10;
            }
            return GetCurX();
        }
        // Get planet Y
        public static double GetCurY()
        {
            if (currentPlanet == 1)
            {
                return new Planet().y = 0;
            }
            if (currentPlanet == 2)
            {
                return new Planet().y = 4.367;
            }
            if (currentPlanet == 3)
            {
                return new Planet().y = 6;
            }
            if (currentPlanet == 4)
            {
                return new Planet().y = -15;
            }
            return GetCurY();
        }

        // Get Destination planet Y
        public static double GetDestY(int currentPlanet)
        {
            if (currentPlanet == 1)
            {
                return new Planet().destY = 0;
            }
            if (currentPlanet == 2)
            {
                return new Planet().destY = 4.367;
            }
            if (currentPlanet == 3)
            {
                return new Planet().destY = 6;
            }
            if (currentPlanet == 4)
            {
                return new Planet().destY = -15;
            }
            return GetDestY(currentPlanet);
        }
        // Get Destination planet X
        public static double GetDestX(int currentPlanet)
        {
            if (currentPlanet == 1)
            {
                return new Planet().destX = 0;
            }
            if (currentPlanet == 2)
            {
                return new Planet().destX = 0;
            }
            if (currentPlanet == 3)
            {
                return new Planet().destX = -3;
            }
            if (currentPlanet == 4)
            {
                return new Planet().destX = 15;
            }
            return GetDestX(currentPlanet);
        }

        // Travel from planet to planet and change curX and curY
        public int Planets(int currentPlanet, double getX, double getY, double destX, double destY)
        {
            Program.UI();
            if (currentPlanet == Planet.currentPlanet)
            {
                Console.WriteLine("You are already here!! No need to travel anywhere..");
                Console.WriteLine("Press 'enter' to return to Menu");
                Console.ReadLine();
            }
            else if (currentPlanet != Planet.currentPlanet)
            {
                Planet.currentPlanet = currentPlanet;
                Console.WriteLine("Heading to {0}!", GetPlanetName(currentPlanet));
                Console.WriteLine("Distance is: {0}LYs", Math.Round(Program.Distance(getX, getY, destX, destY), 3));
                Console.WriteLine("It will take you: {0}yrs", V.timePassage = Math.Round(Program.Distance(getX, getY, destX, destY) / Program.Velocity(Ship.ShowShipSpeed(Ship.currentShip)), 2));
                Console.WriteLine();
                Console.WriteLine("type 'GO' to depart");
                Console.WriteLine("press 'enter' to go back to main menu");
                string conf = Console.ReadLine().ToLower();

                if (conf == "go")
                {
                    Planet.currentPlanet = currentPlanet;
                    V.time += V.timePassage;
                    GetPlanetName(currentPlanet);
                    GetCurX();
                    GetCurY();
                    Program.RandomNumbers();
                }
                else
                {
                    Console.WriteLine("Returning to Menu");
                    System.Threading.Thread.Sleep(1100);
                }

            }

            return currentPlanet;
        }
    }
}
