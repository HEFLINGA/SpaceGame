using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    public class V
    {
        // Decleration of variables

        #region Public Variable Decleration
        public static Random rnd = new Random();

        // Inventory and item variables
        public static int curInventory = 0;
        public static int maxInventory = 0;
        public static int remInventory = 0;
        public static int invFood = 0;
        public static int invResearch = 0;
        public static int invAnimals = 0;
        public static int invWater = 0;
        public static int invFuel = 0;
        public static int cost = 0;
        public static int price = 0;
        public static int credits = 10000;
        public static int totalCredits = 0;
        public static int costFood = 2000;
        public static int costResearch = 3000;
        public static int costAnimals = 4000;
        public static int costWater = 5000;
        public static int costFuel = 6000;

        //various variables
        public static double timePassage = 0;
        public static double time = 0;
        public static double speed = 0;
        public static double distance = 0;
        public static string character = "";

        // ship variables
        public static string shipName = "";
        public static int currentShip = 0;
        public static int shipPrice = 0;
        public static int tier1Ship = 1;
        public static int tier2Ship = 2;
        public static int tier3Ship = 3;

        // Planets and travel variables
        public static string planetName = "";
        public static int currentPlanet = 0;
        public static int earth = 1;
        public static int alphaCentauri = 2;
        public static int trappist = 3;
        public static int krootabulon = 4;
        public static double x = 0;
        public static double y = 0;
        public static double destX = 0;
        public static double destY = 0;
        public static double velocity = 0;
        #endregion
    }
}
