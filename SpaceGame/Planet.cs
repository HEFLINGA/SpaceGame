using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Planet
    {
        public double x = 0;
        public double y = 0;
        public string planetName = "";
        public int currentPlanet = 0;


        public Planet()
        {

        }

        public Planet(string planetName, double x, double y, int currentPlanet)
        {
            this.planetName = planetName;
            this.x = x;
            this.y = y;
            this.currentPlanet = currentPlanet;


        }

    }
}
