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
        public string planetName = "";
        public static int currentPlanet;

        public static int PlanetEarth()
        {
            return currentPlanet = 1;
        }
        public static int PlanetAlphaCentauri()
        {
            return currentPlanet = 2;
        }
        public static int PlanetTrappist()
        {
            return currentPlanet = 3;
        }
        public static int Planetkrootabulon()
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
                return new Planet().x = 3;
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
                return new Planet().y = -7;
            }
            return GetCurY();
        }

        // Get current planet
        public static void GetPlanet(int currentPlanet)
        {
            if (currentPlanet == 1)
            {
                PlanetEarth();
            }
            else if (currentPlanet == 2)
            {
                PlanetAlphaCentauri();
            }
            else if (currentPlanet == 3)
            {
                PlanetTrappist();
            }
            else if (currentPlanet == 4)
            {
                Planetkrootabulon();
            }
        }
    }
}
