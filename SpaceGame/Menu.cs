using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    public class Menu
    {
        // Custom default constructor
        public Menu()
        {

        }

        // Congrats Window when buying ship
        private void Congrats()
        {
            Program.UI();
            Console.WriteLine("Congratulations on your new ship!!!!!");
            Console.WriteLine("You now have a new max speed, cargo, and fuel!");
            Console.WriteLine();
            Console.WriteLine("New Max Speed: {0}.  New Max Cargo: {1}. New Max Fuel: {2}", Ship.ShowShipSpeed(Ship.currentShip), V.maxInventory, Ship.ShowShipMaxFuel(Ship.currentShip));
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
                    new Ship().ShipCargo(5);
                    new Ship().ShipSpeed(3);
                    new Ship().ShipVelocity(Program.Velocity(3));
                    new Ship().ShipMaxFuel(35);
                    Ship.curFuel = 35;
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
            private int UssSchwiftiestShip()
            {
                if ((Ship.currentShip != 3) && (V.credits >= 50000))
                {
                    V.credits -= 50000;
                    Ship.currentShip = 3;
                    new Ship().ShipName("USS Schwifty Ship");
                    new Ship().ShipCargo(10);
                    new Ship().ShipSpeed(6);
                    new Ship().ShipVelocity(Program.Velocity(6));
                    new Ship().ShipMaxFuel(60);
                    Ship.curFuel = 60;
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
                Console.WriteLine("press 'Enter' to leave the trading post");
                Console.WriteLine();
                Console.WriteLine("Star Explorer! Price: 20000 Credits. Speed: 3. Cargo: 5. Fuel: 35");
                Console.WriteLine("USS Schwifty Ship! Price: 50000 Credits. Speed: 6. Cargo: 10. Fuel 60");
                Console.WriteLine("Fuel for your ship! Price: 500 Credits per 1 Fuel");

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
                        new ShipBuy().UssSchwiftiestShip();
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
                if ((V.curInventory < V.maxInventory) && (V.credits >= V.costFood))
                {
                    V.credits -= V.costFood;
                    V.invFood += 1;
                }
                else if (V.credits <= V.costFood)
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
                if ((V.curInventory < V.maxInventory) && (V.credits >= V.costResearch))
                {
                    V.credits -= V.costResearch;
                    V.invResearch += 1;
                }
                else if (V.credits <= V.costResearch)
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
                if ((V.curInventory < V.maxInventory) && (V.credits >= V.costAnimals))
                {
                    V.credits -= V.costAnimals;
                    V.invAnimals += 1;
                }
                else if (V.credits <= V.costAnimals)
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
                if ((V.remInventory >= 2) && (V.credits >= V.costWater))
                {
                    V.credits -= V.costWater;
                    V.invWater += 2;
                }
                else if (V.credits <= V.costWater)
                {
                    Program.UI();
                    Console.WriteLine("You do not have enough Credits to purchase item!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }
                else if (V.remInventory <= 1)
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
                if ((V.remInventory >= 5) && (V.credits >= V.costDarkMatter))
                {
                    V.credits -= V.costDarkMatter;
                    V.invDarkMatter += 5;
                }
                else if (V.credits <= V.costDarkMatter)
                {
                    Program.UI();
                    Console.WriteLine("You do not have enough Credits to purchase item!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }
                else if (V.remInventory <= 4)
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
                    Console.WriteLine("press 'Enter' to leave the trading post");
                    Console.WriteLine();
                    Console.WriteLine($"Food, price: {V.costFood}. This will take up 1 cargo slot");
                    Console.WriteLine($"Research, price: {V.costResearch}. This will take up 1 cargo slot");
                    Console.WriteLine($"Animals, price: {V.costAnimals}. This will take up 1 cargo slot");
                    Console.WriteLine($"Water, price: {V.costWater}. This will take up 2 cargo slots");
                    Console.WriteLine($"Dark Matter, price: {V.costDarkMatter}. This will take up 5 cargo slots");
                    Console.WriteLine("'Inv' to check your current inventory");

                    buyInput = Console.ReadLine().ToLower();
                    switch (buyInput)
                    {
                        case "food":
                            Console.Clear();
                            CargoFood();
                            Program.UI();
                            break;
                        case "research":
                            Console.Clear();
                            CargoResearch();
                            Program.UI();
                            break;
                        case "animals":
                            Console.Clear();
                            CargoAnimals();
                            Program.UI();
                            break;
                        case "water":
                            Console.Clear();
                            CargoWater();
                            Program.UI();
                            break;
                        case "darkmatter":
                        case "dark matter":
                            Console.Clear();
                            CargoDarkMatter();
                            Program.UI();
                            break;
                        case "inv":
                            Console.Clear();
                            V.Inventory(V.maxInventory, V.curInventory);
                            Program.UI();
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

        // Sell class for all selling of inventory. Used class within menu class to contain information for clearity and cleanness of code;
        public class Sell
        {
            // Code for selling food
            private int CargoFood()
            {
                if (V.invFood >= 1)
                {
                    V.credits += V.costFood;
                    V.totalCredits += V.costFood;
                    V.invFood -= 1;
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
                    V.credits += V.costResearch;
                    V.totalCredits += V.costResearch;
                    V.invResearch -= 1;
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
                    V.credits += V.costAnimals;
                    V.totalCredits += V.costAnimals;
                    V.invAnimals -= 1;
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
                    V.credits += V.costWater;
                    V.totalCredits += V.costWater;
                    V.invWater -= 2;
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
                    V.credits += V.invDarkMatter;
                    V.totalCredits += V.invDarkMatter;
                    V.invDarkMatter -= 5;
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
                    Console.WriteLine("press 'Enter' to leave the trading post");
                    Console.WriteLine();
                    Console.WriteLine($"Food, sale price: {V.costFood}");
                    Console.WriteLine($"Research, sale price: {V.costResearch}");
                    Console.WriteLine($"Animals, sale price: {V.costAnimals}");
                    Console.WriteLine($"Water, sale price: {V.costWater}");
                    Console.WriteLine($"Dark Matter, sale price: {V.costDarkMatter}");
                    Console.WriteLine("'Inv' to check your current Inventory");

                    sellInput = Console.ReadLine().ToLower();
                    switch (sellInput)
                    {
                        case "food":
                            Console.Clear();
                            CargoFood();
                            Program.UI();
                            break;
                        case "research":
                            Console.Clear();
                            CargoResearch();
                            Program.UI();
                            break;
                        case "animals":
                            Console.Clear();
                            CargoAnimals();
                            Program.UI();
                            break;
                        case "water":
                            Console.Clear();
                            CargoWater();
                            Program.UI();
                            break;
                        case "darkmatter":
                        case "dark matter":
                            Console.Clear();
                            CargoDarkMatter();
                            Program.UI();
                            break;
                        case "inv":
                            Console.Clear();
                            V.Inventory(V.maxInventory, V.curInventory);
                            Program.UI();
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
            Console.WriteLine("press 'Enter' to leave the space port and return to Main Menu");
            Console.WriteLine();
            // Bools for deciding if you are in range of planets
            #region Bool for range
            bool inRange1 = false;
            bool inRange2 = false;
            bool inRange3 = false;
            bool inRange4 = false;
            bool inRange5 = false;
            bool inRange6 = false;
            bool inRange7 = false;
            bool inRange8 = false;
            #endregion
            // Nested if statements determening whether or not you are in range of a planet
            if (Planet.DistanceToPlanets(Planet.currentPlanet, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(1), Planet.GetDestY(1)) <= Ship.curFuel)
            {
                Console.WriteLine("Planet {0} is in Range!", Planet.GetPlanetName(1));
                inRange1 = true;
                if (Planet.DistanceToPlanets(Planet.currentPlanet, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(2), Planet.GetDestY(2)) <= Ship.curFuel)
                {
                    Console.WriteLine("Planet {0} is in Range!", Planet.GetPlanetName(2));
                    inRange2 = true;
                    if (Planet.DistanceToPlanets(Planet.currentPlanet, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(3), Planet.GetDestY(3)) <= Ship.curFuel)
                    {
                        Console.WriteLine("Planet {0} is in Range!", Planet.GetPlanetName(3));
                        inRange3 = true;
                        if (Planet.DistanceToPlanets(Planet.currentPlanet, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(4), Planet.GetDestY(4)) <= Ship.curFuel)
                        {
                            Console.WriteLine("Planet {0} is in Range!", Planet.GetPlanetName(4));
                            inRange4 = true;
                            if (Planet.DistanceToPlanets(Planet.currentPlanet, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(5), Planet.GetDestY(5)) <= Ship.curFuel)
                            {
                                Console.WriteLine("Planet {0} is in Range!", Planet.GetPlanetName(5));
                                inRange5 = true;
                                if (Planet.DistanceToPlanets(Planet.currentPlanet, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(6), Planet.GetDestY(6)) <= Ship.curFuel)
                                {
                                    Console.WriteLine("Planet {0} is in Range!", Planet.GetPlanetName(6));
                                    inRange6 = true;
                                    if (Planet.DistanceToPlanets(Planet.currentPlanet, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(7), Planet.GetDestY(7)) <= Ship.curFuel)
                                    {
                                        Console.WriteLine("Planet {0} is in Range!", Planet.GetPlanetName(7));
                                        inRange7 = true;
                                        if (Planet.DistanceToPlanets(Planet.currentPlanet, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(8), Planet.GetDestY(8)) <= Ship.curFuel)
                                        {
                                            Console.WriteLine("Planet {0} is in Range!", Planet.GetPlanetName(8));
                                            inRange8 = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            // Code for changing planetary information based on range and user input
            #region Planet changed based on range and input
            travelInput = Console.ReadLine().ToLower();
            if ((travelInput == "earth") && (inRange1 == true))
            {
                Console.Clear();
                new Planet().Planets(1, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(1), Planet.GetDestY(1));
                Program.UI();
            }
            else if ((travelInput == "alpha centauri") && (inRange2 == true))
            {
                Console.Clear();
                new Planet().Planets(2, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(2), Planet.GetDestY(2));
                Program.UI();
            }
            else if ((travelInput == "trappist") && (inRange3 == true))
            {
                Console.Clear();
                new Planet().Planets(3, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(3), Planet.GetDestY(3));
                Program.UI();
            }
            else if ((travelInput == "krootabulon") && (inRange4 == true))
            {
                Console.Clear();
                new Planet().Planets(4, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(4), Planet.GetDestY(4));
                Program.UI();
            }
            else if ((travelInput == "bird world") && (inRange5 == true))
            {
                Console.Clear();
                new Planet().Planets(5, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(5), Planet.GetDestY(5));
                Program.UI();
            }
            else if ((travelInput == "gazorpazorp") && (inRange6 == true))
            {
                Console.Clear();
                new Planet().Planets(6, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(6), Planet.GetDestY(6));
                Program.UI();
            }
            else if ((travelInput == "alphabetruim") && (inRange7 == true))
            {
                Console.Clear();
                new Planet().Planets(7, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(7), Planet.GetDestY(7));
                Program.UI();
            }
            else if ((travelInput == "planet squanch") && (inRange8 == true))
            {
                Console.Clear();
                new Planet().Planets(8, Planet.GetCurX(), Planet.GetCurY(), Planet.GetDestX(8), Planet.GetDestY(8));
                Program.UI();
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
