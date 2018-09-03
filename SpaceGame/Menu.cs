using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    public class Menu
    {
        // Bool to let the game know you are stranded and put Game over to TRUE
        public static bool stranded = false;

        // Variables for cost of items
        private static int[] costOfItem = new int[5] { 2000, 3000, 4000, 5000, 50000 };

        // Code for RandomNumber generator
        public void RandomNumbers(int planetaryFactor)
        {
            costOfItem[0] = V.rnd.Next(2000, 3000 + planetaryFactor);
            costOfItem[1] = V.rnd.Next(1000, 5000 + planetaryFactor);
            costOfItem[2] = V.rnd.Next(2000, 5000 + planetaryFactor);
            costOfItem[3] = V.rnd.Next(1000, 5000 + planetaryFactor);
            costOfItem[4] = V.rnd.Next(40000, 50000 + planetaryFactor);
        }

        // General loading screen!
        private void LoadingScreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(53, 16);
            Console.Write("Loading.");
            System.Threading.Thread.Sleep(200);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(250);
            Console.Write(".");
            System.Threading.Thread.Sleep(200);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(250);
            Console.Write(".");
            System.Threading.Thread.Sleep(560);
            Console.Write(".");
        }

        //Show LoadingScreen to user
        public static void ShowLoadingScreen()
        {
            new Menu().LoadingScreen();
        }

        // Custom default constructor
        public Menu(){}
        
        // Congrats Window when buying ship
        private void Congrats()
        {
            Program.UI();
            Console.WriteLine("Congratulations on your new ship!!!!!");
            Console.WriteLine("You now have a new max speed, cargo, and fuel!");
            Console.WriteLine();
            Console.WriteLine("New Max Speed: {0}.  New Max Cargo: {1}. New Max Fuel: {2}", Ship.ShowShipSpeed(Ship.currentShip), V.maxInventory, Ship.ShowShipMaxFuel(Ship.currentShip));
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Press 'enter' to return to Main Menu");
            Console.ReadLine();
        }

        // Ship class for all buying of ships. Used class within menu class to contain information for clearity and cleanness of code
        public class ShipBuy
        {
            // Ship Menu for buying ships
            // Ship options
            private int StarExplorer()
            {
                if ((Ship.currentShip != 2) && (V.credits >= 20000))
                {
                    V.credits -= 20000;
                    Ship.currentShip = 2;
                    new Ship().ShipName("Star Explorer");
                    new Ship().ShipCargo(8);
                    new Ship().ShipSpeed(2.5);
                    new Ship().ShipVelocity(Program.Velocity(2.5));
                    new Ship().ShipMaxFuel(45);
                    Ship.curFuel = 45;
                    new Menu().Congrats();
                }
                else if (Ship.currentShip == 2)
                {
                    Console.WriteLine($"You already own that ship! No need to have 2 of them.. you are but one person {V.character}");
                    Console.WriteLine("Press Enter to return to Main Menu");
                    Console.ReadLine();
                }
                else if (V.credits < 20000)
                {
                    Console.WriteLine("You are to broke to afford such a ship.. Get more credits and come back");
                    Console.WriteLine("Press Enter to return to Main Menu");
                    Console.ReadLine();
                }

                return Ship.currentShip;
            }
            private int UssSchwiftyShip()
            {
                if ((Ship.currentShip != 3) && (V.credits >= 50000))
                {
                    V.credits -= 50000;
                    Ship.currentShip = 3;
                    new Ship().ShipName("USS Schwifty Ship");
                    new Ship().ShipCargo(15);
                    new Ship().ShipSpeed(4);
                    new Ship().ShipVelocity(Program.Velocity(4));
                    new Ship().ShipMaxFuel(100);
                    Ship.curFuel = 100;
                    new Menu().Congrats();
                }
                else if (Ship.currentShip == 3)
                {
                    Console.WriteLine($"You already own that ship! No need to have 2 of them.. you are but one person {V.character}");
                    Console.WriteLine("Press Enter to return to Main Menu");
                    Console.ReadLine();
                }
                else if (V.credits < 50000)
                {
                    Console.WriteLine("You are to broke to afford such a ship.. Get more credits and come back");
                    Console.WriteLine("Press Enter to return to Main Menu");
                    Console.ReadLine();
                }

                return Ship.currentShip;
            }
            // Ship menu
            public void ShipMenu()
            {
                string shipMenuInput = "";

                Program.UI();

                Console.WriteLine("What would you like to buy?: \n" +
                                        "(Type name of Ship to purchase)");                
                Console.WriteLine();
                Console.WriteLine("Type name of ship you would like to buy, or 'fuel' to buy Fuel!");
                Console.WriteLine();
                Console.WriteLine("'Star Explorer'! - Ship Price: 20000 Credits. Speed: 2.5. Cargo: 8. Fuel: 45");
                Console.WriteLine("'USS Schwifty Ship'! - Ship Price: 50000 Credits. Speed: 4. Cargo: 15. Fuel 100");
                Console.WriteLine();
                Console.WriteLine("'Fuel' - Fuel for your ship!");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine();
                Console.WriteLine("press 'enter' to leave the trading post");

                shipMenuInput = Console.ReadLine().ToLower();
                switch (shipMenuInput)
                {
                    case "star explorer":
                        Console.Clear();
                        new ShipBuy().StarExplorer();
                        Program.UI();
                        break;
                    case "uss schwiftiest ship":
                        Console.Clear();
                        new ShipBuy().UssSchwiftyShip();
                        Program.UI();
                        break;
                    case "fuel":
                        Console.Clear();
                        Ship.BuyingFuel();
                        Program.UI();
                        break;
                    default:
                        Console.WriteLine("Returning to Menu");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        break;

                }
            }
        }

        // Buy class for all buying of inventory. Used class within menu class to contain information for clearity and cleanness of code
        public class Buy
        {
            // Code for buying food
            private int CargoFood()
            {
                if ((V.curInventory < V.maxInventory) && (V.credits >= costOfItem[0]))
                {
                    V.credits -= costOfItem[0];
                    V.invFood += 1;
                    Console.WriteLine("You bought 1 Food!");
                    Console.WriteLine("Loading..");
                    System.Threading.Thread.Sleep(500);
                }
                else if (V.credits <= costOfItem[0])
                {
                    Program.UI();
                    Console.WriteLine("You do not have enough Credits to purchase item!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }
                else if ((V.remInventory == 0) || (V.curInventory == V.maxInventory))
                {
                    Program.UI();
                    Console.WriteLine("You do not have enough space in your inventory!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return V.invFood;
            }

            // Code for buying research
            private int CargoResearch()
            {
                if ((V.curInventory < V.maxInventory) && (V.credits >= costOfItem[1]))
                {
                    V.credits -= costOfItem[1];
                    V.invResearch += 1;
                    Console.WriteLine("You bought 1 Research!");
                    Console.WriteLine("Loading..");
                    System.Threading.Thread.Sleep(500);
                }
                else if (V.credits <= costOfItem[1])
                {
                    Program.UI();
                    Console.WriteLine("You do not have enough Credits to purchase item!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }
                else if ((V.remInventory == 0) || (V.curInventory == V.maxInventory))
                {
                    Program.UI();
                    Console.WriteLine("You do not have enough space in your inventory!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return V.invResearch;
            }

            // Code for buying animals
            private int CargoAnimals()
            {
                if ((V.curInventory < V.maxInventory) && (V.credits >= costOfItem[2]))
                {
                    V.credits -= costOfItem[2];
                    V.invAnimals += 1;
                    Console.WriteLine("You bought 1 Anaimal!");
                    Console.WriteLine("Loading..");
                    System.Threading.Thread.Sleep(500);
                }
                else if (V.credits <= costOfItem[2])
                {
                    Program.UI();
                    Console.WriteLine("You do not have enough Credits to purchase item!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }
                else if ((V.remInventory == 0) || (V.curInventory == V.maxInventory))
                {
                    Program.UI();
                    Console.WriteLine("You do not have enough space in your inventory!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return V.invAnimals;
            }

            // Code for buying water
            private int CargoWater()
            {
                if ((V.curInventory <= V.maxInventory - 2) && (V.credits >= costOfItem[3]))
                {
                    V.credits -= costOfItem[3];
                    V.invWater += 2;
                    Console.WriteLine("You bought 1 Water! (Takes 2 cargo slots to hold)");
                    Console.WriteLine("Loading..");
                    System.Threading.Thread.Sleep(500);
                }
                else if (V.credits <= costOfItem[3])
                {
                    Program.UI();
                    Console.WriteLine("You do not have enough Credits to purchase item!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }
                else if (V.curInventory >= V.maxInventory - 1)
                {
                    Program.UI();
                    Console.WriteLine("You do not have enough space in your inventory!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return V.invWater;
            }

            // Code for buying dark matter
            private int CargoDarkMatter()
            {
                if ((V.curInventory <= V.maxInventory - 5) && (V.credits >= costOfItem[4]))
                {
                    V.credits -= costOfItem[4];
                    V.invDarkMatter += 5;
                    Console.WriteLine("You bought some DARK MATTER! (Takes up 5 whole slots)");
                    Console.WriteLine("Loading..");
                    System.Threading.Thread.Sleep(500);
                }
                else if (V.credits <= costOfItem[4])
                {
                    Program.UI();
                    Console.WriteLine("You do not have enough Credits to purchase item!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }
                else if (V.curInventory >= V.maxInventory - 4)
                {
                    Program.UI();
                    Console.WriteLine("You do not have enough space in your inventory!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return V.invDarkMatter;
            }

            // Buying Menu
            public void BuyMenu()
            {
                string buyInput = "";

                do
                {
                    Program.UI();
                    V.CheckInventory(V.curInventory, V.maxInventory);
                    Program.UI();

                    Console.WriteLine("What would you like to buy?: \n" +
                                        "(Type name of Item to purchase)");
                    Console.WriteLine("For buying multiples of the same item after the initial buy, use up/down");
                    Console.WriteLine("arrows to go to name, and press 'enter'");
                    Console.WriteLine();
                    Console.WriteLine($"'Food', price: {costOfItem[0]}. This will take up 1 cargo slot");
                    Console.WriteLine($"'Research', price: {costOfItem[1]}. This will take up 1 cargo slot");
                    Console.WriteLine($"'Animals', price: {costOfItem[2]}. This will take up 1 cargo slot");
                    Console.WriteLine($"'Water', price': {costOfItem[3]}. This will take up 2 cargo slots");
                    Console.WriteLine($"'Dark Matter', price: {costOfItem[4]}. This will take up 5 cargo slots");
                    Console.WriteLine("'Inv' to check your current inventory");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("press 'Enter' to leave the trading post");

                    buyInput = Console.ReadLine().ToLower();
                    switch (buyInput)
                    {
                        case "food":
                            CargoFood();
                            Program.UI();
                            break;
                        case "research":
                            CargoResearch();
                            Program.UI();
                            break;
                        case "animals":
                            CargoAnimals();
                            Program.UI();
                            break;
                        case "water":
                            CargoWater();
                            Program.UI();
                            break;
                        case "darkmatter":
                        case "dark matter":
                            CargoDarkMatter();
                            Program.UI();
                            break;
                        case "inv":
                            Program.UI();
                            V.Inventory(V.maxInventory, V.curInventory);
                            break;
                        case "":
                            Console.WriteLine("Returning to Menu");
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            break;
                    }
                } while (buyInput != "");
            }
        }

        // Sell class for all selling of inventory. Used class within menu class to contain information for clearity and cleanness of code
        public class Sell
        {
            // Code for selling food
            private int CargoFood()
            {
                if (V.invFood >= 1)
                {
                    V.credits += costOfItem[0];
                    V.totalCredits += costOfItem[0];
                    V.invFood -= 1;
                    Console.WriteLine("You sold 1 Food!");
                    Console.WriteLine("Loading..");
                    System.Threading.Thread.Sleep(500);
                }
                else if (V.invFood == 0)
                {
                    Program.UI();
                    Console.WriteLine("You do not have any Food in your inventory to sell!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return V.invFood;
            }

            // Code for selling research
            private int CargoResearch()
            {
                if (V.invResearch >= 1)
                {
                    V.credits += costOfItem[1];
                    V.totalCredits += costOfItem[1];
                    V.invResearch -= 1;
                    Console.WriteLine("You sold 1 Research!");
                    Console.WriteLine("Loading..");
                    System.Threading.Thread.Sleep(500);
                }
                else if (V.invResearch == 0)
                {
                    Program.UI();
                    Console.WriteLine("You do not have any Research Items in your inventory to sell!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return V.invResearch;
            }

            // Code for selling animals
            private int CargoAnimals()
            {
                if (V.invAnimals >= 1)
                {
                    V.credits += costOfItem[2];
                    V.totalCredits += costOfItem[2];
                    V.invAnimals -= 1;
                    Console.WriteLine("You sold an Animal!");
                    Console.WriteLine("Loading..");
                    System.Threading.Thread.Sleep(500);
                }
                else if (V.invAnimals == 0)
                {
                    Program.UI();
                    Console.WriteLine("You do not have any Animals in your inventory to sell!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return V.invAnimals;
            }

            // Code for selling water
            private int CargoWater()
            {
                if (V.invWater >= 2)
                {
                    V.credits += costOfItem[3];
                    V.totalCredits += costOfItem[3];
                    V.invWater -= 2;
                    Console.WriteLine("You sold some Water!");
                    Console.WriteLine("Loading..");
                    System.Threading.Thread.Sleep(500);
                }
                else if (V.invWater < 2)
                {
                    Program.UI();
                    Console.WriteLine("You do not have any Water in your inventory to sell!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return V.invWater;
            }

            // Code for selling dark matter
            private int CargoDarkMatter()
            {
                if (V.invDarkMatter >= 5)
                {
                    V.credits += costOfItem[4];
                    V.totalCredits += costOfItem[4];
                    V.invDarkMatter -= 5;
                    Console.WriteLine("You sold some DARK MATTER baby!!!");
                    Console.WriteLine("Loading..");
                    System.Threading.Thread.Sleep(500);
                }
                else if (V.invDarkMatter < 5)
                {
                    Program.UI();
                    Console.WriteLine("You do not have any Fuel in your inventory to Sell!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return V.invDarkMatter;
            }

            // Code for sellMenu
            public void SellMenu()
            {
                string sellInput = "";

                do
                {
                    Program.UI();
                    V.CheckInventory(V.curInventory, V.maxInventory);
                    Program.UI();

                    Console.WriteLine("What would you like to Sell?: \n" +
                                        "(Type name of Item to purchase)");
                    Console.WriteLine("For selling multiples of the same item after the initial sale, use up/down");  
                    Console.WriteLine("arrows to go to name, and press 'enter'");
                    Console.WriteLine();
                    Console.WriteLine($"'Food', sale price: {costOfItem[0]}");
                    Console.WriteLine($"'Research', sale price: {costOfItem[1]}");
                    Console.WriteLine($"'Animals', sale price: {costOfItem[2]}");
                    Console.WriteLine($"'Water', sale price: {costOfItem[3]}");
                    Console.WriteLine($"'Dark Matter', sale price: {costOfItem[4]}");
                    Console.WriteLine("'Inv' to check your current Inventory");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("press 'enter' to leave the trading post");

                    sellInput = Console.ReadLine().ToLower();
                    switch (sellInput)
                    {
                        case "food":
                            CargoFood();
                            Program.UI();
                            break;
                        case "research":
                            CargoResearch();
                            Program.UI();
                            break;
                        case "animals":
                            CargoAnimals();
                            Program.UI();
                            break;
                        case "water":
                            CargoWater();
                            Program.UI();
                            break;
                        case "darkmatter":
                        case "dark matter":
                            CargoDarkMatter();
                            Program.UI();
                            break;
                        case "inv":
                            Program.UI();
                            V.Inventory(V.maxInventory, V.curInventory);                            
                            break;
                        case "":
                            Console.WriteLine("Returning to Menu");
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            break;

                    }
                } while (sellInput != "");
            }
        }

        // Menu for travel and changing of planets in Planets.cs
        public void TravelMenu()
        {
            string travelInput = "";           

            Program.UI();
            Console.WriteLine("Where would you like to go!!: \n" +
                                "(Type name of planet you wish to go to)");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("press 'Enter' to leave the space port and return to Main Menu");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            // Bools for deciding if you are in range of planets
            #region Bool and loops for range
            bool[] inRange = new bool[8];
            for (int i = 0; i < inRange.Length; i++)
            {
                inRange[i] = false;
            }            

            // If statements determening whether or not you are in range of a planet
            if ((Planet.DistanceToPlanets(Planet.currentPlanet, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(1), Planet.GetDestY(1)) <= Ship.curFuel) && (Planet.currentPlanet != 1))
            {
                Console.WriteLine("Planet {0} is in Range!", Planet.GetPlanetName(1));
                inRange[0] = true;
            }
            if ((Planet.DistanceToPlanets(Planet.currentPlanet, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(2), Planet.GetDestY(2)) <= Ship.curFuel) && (Planet.currentPlanet != 2))
            {
                Console.WriteLine("Planet {0} is in Range!", Planet.GetPlanetName(2));
                inRange[1] = true;
            }
            if ((Planet.DistanceToPlanets(Planet.currentPlanet, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(3), Planet.GetDestY(3)) <= Ship.curFuel) && (Planet.currentPlanet != 3))
            {
                Console.WriteLine("Planet {0} is in Range!", Planet.GetPlanetName(3));
                inRange[2] = true;
            }
            if ((Planet.DistanceToPlanets(Planet.currentPlanet, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(4), Planet.GetDestY(4)) <= Ship.curFuel) && (Planet.currentPlanet != 4))
            {
                Console.WriteLine("Planet {0} is in Range!", Planet.GetPlanetName(4));
                inRange[3] = true;
            }
            if ((Planet.DistanceToPlanets(Planet.currentPlanet, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(5), Planet.GetDestY(5)) <= Ship.curFuel) && (Planet.currentPlanet != 5))
            {
                Console.WriteLine("Planet {0} is in Range!", Planet.GetPlanetName(5));
                inRange[4] = true;
            }
            if ((Planet.DistanceToPlanets(Planet.currentPlanet, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(6), Planet.GetDestY(6)) <= Ship.curFuel) && (Planet.currentPlanet != 6))
            {
                Console.WriteLine("Planet {0} is in Range!", Planet.GetPlanetName(6));
                inRange[5] = true;
            }
            if ((Planet.DistanceToPlanets(Planet.currentPlanet, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(7), Planet.GetDestY(7)) <= Ship.curFuel) && (Planet.currentPlanet != 7))
            {
                Console.WriteLine("Planet {0} is in Range!", Planet.GetPlanetName(7));
                inRange[6] = true;
            }
            if ((Planet.DistanceToPlanets(Planet.currentPlanet, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(8), Planet.GetDestY(8)) <= Ship.curFuel) && (Planet.currentPlanet != 8))
            {
                Console.WriteLine("Planet {0} is in Range!", Planet.GetPlanetName(8));
                inRange[7] = true;
            }
            #endregion

            // Code for changing planetary information based on range and user input
            #region Planet changed based on range and input
            travelInput = Console.ReadLine().ToLower();
            if ((travelInput == "earth") && (inRange[0] == true))
            {
                Console.Clear();
                new Planet().Planets(1, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(1), Planet.GetDestY(1), 0);
                Program.UI();
            }
            else if ((travelInput == "alpha centauri") && (inRange[1] == true))
            {
                Console.Clear();
                new Planet().Planets(2, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(2), Planet.GetDestY(2), 500);
                Program.UI();
            }
            else if ((travelInput == "trappist") && (inRange[2] == true))
            {
                Console.Clear();
                new Planet().Planets(3, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(3), Planet.GetDestY(3), 1000);
                Program.UI();
            }
            else if ((travelInput == "krootabulon") && (inRange[3] == true))
            {
                Console.Clear();
                new Planet().Planets(4, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(4), Planet.GetDestY(4), 3000);
                Program.UI();
            }
            else if ((travelInput == "bird world") && (inRange[4] == true))
            {
                Console.Clear();
                new Planet().Planets(5, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(5), Planet.GetDestY(5), 5000);
                Program.UI();
            }
            else if ((travelInput == "gazorpazorp") && (inRange[5] == true))
            {
                Console.Clear();
                new Planet().Planets(6, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(6), Planet.GetDestY(6), 5500);
                Program.UI();
            }
            else if ((travelInput == "alphabetruim") && (inRange[6] == true))
            {
                Console.Clear();
                new Planet().Planets(7, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(7), Planet.GetDestY(7), 8000);
                Program.UI();
            }
            else if ((travelInput == "planet squanch") && (inRange[7] == true))
            {
                Console.Clear();
                new Planet().Planets(8, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(8), Planet.GetDestY(8), 10000);
                Program.UI();
            }
            else if ((inRange[0] == false) 
                && (inRange[1] == false) 
                && (inRange[2] == false) 
                && (inRange[3] == false) 
                && (inRange[4] == false) 
                && (inRange[5] == false) 
                && (inRange[6] == false) 
                && (inRange[7] == false) 
                && (V.credits < 500)
                && (V.curInventory < 1))
                 {
                    stranded = true;
                 }
            else
            {
                Console.WriteLine("Returning to Menu");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
            #endregion
        }
    }
}
