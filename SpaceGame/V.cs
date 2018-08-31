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
        public static int invDarkMatter = 0;
        public static int price = 0;
        public static int credits = 10000;
        public static int totalCredits = 0;

        //various variables
        public static double timePassage = 0;
        public static double time = 0;        
        public static double distance = 0;
        public static string character = "";
        public static double velocity = 0;
        #endregion

        // Code for inventory handling
        public static int Inventory(int maxInventory, int curInventory)
        {
            // remaining inventory space
            remInventory = maxInventory - curInventory;
            if (curInventory > 0)
            {
                Console.WriteLine("You have {0} Food", invFood);
                Console.WriteLine("You have {0} Research", invResearch);
                Console.WriteLine("You have {0} Animals", invAnimals);
                Console.WriteLine("You have {0} Water", invWater);
                Console.WriteLine("You have {0} Dark Matter", invDarkMatter);
                Console.WriteLine("You have {0} out of {1} spaces remaining", remInventory, maxInventory);
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
            }
            else if (curInventory == 0)
            {
                Console.WriteLine("Your inventory is empty!");
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
            }

            return curInventory;
        }

        // Code for inventory checking at runtime (behind the scenes)
        public static int CheckInventory(int curInventory, int maxInventory)
        {
            return curInventory;
        }
    }
}
