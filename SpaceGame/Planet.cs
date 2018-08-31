using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    public class Planet
    {
        // Variables for planets controlling destination X's and Y's for travel
        #region Variables
        private double[] x = new double[8];
        private double[] y = new double[8];
        private double[] destX = new double[8];
        private double[] destY = new double[8];
        private string[] planetName = new string[8];
        public static int currentPlanet;
        #endregion

        // Default constructor
        public Planet() { }

        // Travel loading screen
        private void Loading(int currentPlanet)
        {
            Program.UI();

            Console.SetCursorPosition(49, 11);            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Heading to {GetPlanetName(currentPlanet)}");
            Console.SetCursorPosition(54, 16);
            Console.Write("Loading.");
            System.Threading.Thread.Sleep(200);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(250);
            Console.Write(".");
            System.Threading.Thread.Sleep(200);
            Console.Write(".");
            System.Threading.Thread.Sleep(250);
            Console.Write(".");
            System.Threading.Thread.Sleep(560);
            Console.Write(".");
        }

        // Get planet name
        public static string GetPlanetName(int currentPlanet)
        {
            if (currentPlanet == 1)
            {
                return new Planet().planetName[0] = "Earth";
            }
            else if (currentPlanet == 2)
            {
                return new Planet().planetName[1] = "Alpha Centauri";
            }
            else if (currentPlanet == 3)
            {
                return new Planet().planetName[2] = "TRAPPIST-1";
            }
            else if (currentPlanet == 4)
            {
                return new Planet().planetName[3] = "Krootabulon";
            }
            else if (currentPlanet == 5)
            {
                return new Planet().planetName[4] = "Bird World";
            }
            else if (currentPlanet == 6)
            {
                return new Planet().planetName[5] = "Gazorpazorp";
            }
            else if (currentPlanet == 7)
            {
                return new Planet().planetName[6] = "Alphabetrium";
            }
            else if (currentPlanet == 8)
            {
                return new Planet().planetName[7] = "Planet Squanch";
            }

            return GetPlanetName(currentPlanet);
        }

        // Get planet X
        public static double GetCurX()
        {
            if (currentPlanet == 1)
            {
                return new Planet().x[0] = 0;
            }
            else if (currentPlanet == 2)
            {
                return new Planet().x[1] = 0;
            }
            else if (currentPlanet == 3)
            {
                return new Planet().x[2] = -3;
            }
            else if (currentPlanet == 4)
            {
                return new Planet().x[3] = 10;
            }
            else if (currentPlanet == 5)
            {
                return new Planet().x[4] = 20;
            }
            else if (currentPlanet == 6)
            {
                return new Planet().x[5] = -25;
            }
            else if (currentPlanet == 7)
            {
                return new Planet().x[6] = 45;
            }
            else if (currentPlanet == 8)
            {
                return new Planet().x[7] = 55;
            }

            return GetCurX();
        }

        // Get planet Y
        public static double GetCurY()
        {
            if (currentPlanet == 1)
            {
                return new Planet().y[0] = 0;
            }
            else if (currentPlanet == 2)
            {
                return new Planet().y[1] = 4.367;
            }
            else if (currentPlanet == 3)
            {
                return new Planet().y[2] = 6;
            }
            else if (currentPlanet == 4)
            {
                return new Planet().y[3] = -15;
            }
            else if (currentPlanet == 5)
            {
                return new Planet().y[4] = -25;
            }
            else if (currentPlanet == 6)
            {
                return new Planet().y[5] = 33;
            }
            else if (currentPlanet == 7)
            {
                return new Planet().y[6] = -40;
            }
            else if (currentPlanet == 8)
            {
                return new Planet().y[7] = -50;
            }

            return GetCurY();
        }

        // Get Destination planet Y
        public static double GetDestY(int currentPlanet)
        {
            if (currentPlanet == 1)
            {
                return new Planet().destY[0] = 0;
            }
            else if (currentPlanet == 2)
            {
                return new Planet().destY[1] = 4.367;
            }
            else if (currentPlanet == 3)
            {
                return new Planet().destY[2] = 6;
            }
            else if (currentPlanet == 4)
            {
                return new Planet().destY[3] = -15;
            }
            else if (currentPlanet == 5)
            {
                return new Planet().destY[4] = -25;
            }
            else if (currentPlanet == 6)
            {
                return new Planet().destY[5] = 33;
            }
            else if (currentPlanet == 7)
            {
                return new Planet().destY[6] = -40;
            }
            else if (currentPlanet == 8)
            {
                return new Planet().destY[7] = -50;
            }

            return GetDestY(currentPlanet);
        }

        // Get Destination planet X
        public static double GetDestX(int currentPlanet)
        {
            if (currentPlanet == 1)
            {
                return new Planet().destX[0] = 0;
            }
            else if (currentPlanet == 2)
            {
                return new Planet().destX[1] = 0;
            }
            else if (currentPlanet == 3)
            {
                return new Planet().destX[2] = -3;
            }
            else if (currentPlanet == 4)
            {
                return new Planet().destX[3] = 10;
            }
            else if (currentPlanet == 5)
            {
                return new Planet().destX[4] = 20;
            }
            else if (currentPlanet == 6)
            {
                return new Planet().destX[5] = -25;
            }
            else if (currentPlanet == 7)
            {
                return new Planet().destX[6] = 45;
            }
            else if (currentPlanet == 8)
            {
                return new Planet().destX[7] = 55;
            }

            return GetDestX(currentPlanet);
        }

        // Travel from planet to planet and change curX and curY
        public int Planets(int currentPlanet, double getX, double getY, double destX, double destY, int planetaryFactor)
        {
            Program.UI();
            if (currentPlanet == Planet.currentPlanet)
            {
                Console.WriteLine("You are already here!! No need to travel anywhere..");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Press 'enter' to return to Menu");
                Console.ReadLine();
            }
            else if (currentPlanet != Planet.currentPlanet)
            {
                Console.WriteLine("Heading to {0}!", GetPlanetName(currentPlanet));
                Console.WriteLine("Distance is: {0}LYs", Math.Round(Program.Distance(getX, getY, destX, destY), 3));
                Console.WriteLine("It will take you: {0}yrs", V.timePassage = Math.Round(Program.Distance(getX, getY, destX, destY) / Program.Velocity(Ship.ShowShipSpeed(Ship.currentShip)), 2));
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("type 'GO' to depart");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine();
                Console.WriteLine("press 'enter' to go back to main menu");
                Console.ForegroundColor = ConsoleColor.Green;
                double distance = Math.Ceiling(Program.Distance(getX, getY, destX, destY));
                string conf = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                if (conf == "go")
                {
                    Planet.currentPlanet = currentPlanet;
                    V.time += V.timePassage;
                    GetPlanetName(currentPlanet);
                    GetCurX();
                    GetCurY();
                    Ship.curFuel -= distance;
                    new Menu().RandomNumbers(planetaryFactor);
                    new Planet().Loading(currentPlanet);
                }
                else
                {
                    Console.WriteLine("Returning to Menu");
                    System.Threading.Thread.Sleep(1100);
                }

            }

            return currentPlanet;
        }

        // Get distance to planets..?
        public static double DistanceToPlanets(int currentPlanet, double getX, double getY, double destX, double destY)
        {
            return Math.Round(Program.Distance(getX, getY, destX, destY), 3);
        }
    }
}
