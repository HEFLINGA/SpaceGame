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
            Console.WriteLine("You now have a new max speed and cargo!");
            Console.WriteLine();
            Console.WriteLine("New Max speed: {0}.  New Max Cargo: {1}", Ship.ShowShipSpeed(Ship.currentShip), V.maxInventory);
            Console.ReadLine();
        }

        // Ship class for all buying of ships
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
                Console.WriteLine("Star Explorer! Price: 20000 credits. speed: 3. Cargo: 5");
                Console.WriteLine("USS Schwifty Ship! Price: 50000 credits. speed: 6. Cargo: 10");

                shipMenuInput = Console.ReadLine();
                switch (shipMenuInput)
                {
                    case "Star Explorer":
                    case "star explorer":
                        Console.Clear();
                        new ShipBuy().StarExplorer();
                        Program.UI();
                        break;
                    case "USS Schwiftiest Ship":
                    case "uss schwiftiest ship":
                        Console.Clear();
                        new ShipBuy().UssSchwiftiestShip();
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

        // Buy class for all buying of inventory
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
            // Code for buying fuel (Resource)
            private int CargoFuel()
            {
                if ((V.remInventory >= 2) && (V.credits >= V.costFuel))
                {
                    V.credits -= V.costFuel;
                    V.invFuel += 2;
                }
                else if (V.credits <= V.costFuel)
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

                return V.invFuel;
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
                    Console.WriteLine($"Fuel, price: {V.costFuel}. This will take up 2 cargo slots");
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
                        case "fuel":
                            Console.Clear();
                            CargoFuel();
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

        // Sell class for all selling of inventory;
        public class Sell
        {
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
            private int CargoFuel()
            {
                if (V.invFuel >= 2)
                {
                    V.credits += V.costFuel;
                    V.totalCredits += V.costFuel;
                    V.invFuel -= 2;
                }
                else if (V.invFuel < 2)
                {
                    Program.UI();
                    Console.WriteLine("You do not have any Fuel in your inventory to Sell!");
                    Console.WriteLine("Press 'Enter' to return to Menu");
                    Console.ReadLine();
                }

                return V.invFuel;
            }

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
                    Console.WriteLine($"Fuel, sale price: {V.costFuel}");
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
                        case "fuel":
                            Console.Clear();
                            CargoFuel();
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

        // Planets and travel variables        
        private double destX = 0;
        private double destY = 0;        

        // Travel class for all travel handling;        
        public class Travel
        {
            private int Earth()
            {
                Program.UI();
                if (Planet.currentPlanet == 1)
                {
                    Console.WriteLine("You are already here!! No need to travel anywhere..");
                    Console.WriteLine("Press 'enter' to return to Menu");
                    Console.ReadLine();
                }
                else if (Planet.currentPlanet != 1)
                {
                    Console.WriteLine("Heading to Earth!");
                    Console.WriteLine("Distance is: {0}LYs", Math.Round(Program.Distance(Planet.GetCurX(), Planet.GetCurY(), new Menu().destX = 0, new Menu().destY = 0), 3));
                    Console.WriteLine("It will take you: {0}yrs", V.timePassage = Math.Round(Program.Distance(Planet.GetCurX(), Planet.GetCurY(), new Menu().destX = 0, new Menu().destY = 0) / Program.Velocity(Ship.ShowShipSpeed(Ship.currentShip)), 2));
                    Console.WriteLine();
                    Console.WriteLine("type 'GO' to depart");
                    Console.WriteLine("press 'enter' to go back to main menu");
                    string conf = Console.ReadLine().ToLower();

                    if (conf == "go")
                    {
                        Planet.currentPlanet = 1;
                        V.time += V.timePassage;
                        Planet.GetPlanetName(1);
                        Planet.GetCurX();
                        Planet.GetCurY();
                        Program.RandomNumbers();
                    }
                    else
                    {
                        Console.WriteLine("Returning to Menu");
                        System.Threading.Thread.Sleep(1100);
                    }

                }

                return Planet.currentPlanet;
            }

            private int AlphaCentauri()
            {
                Program.UI();
                if (Planet.currentPlanet == 2)
                {
                    Console.WriteLine("You are already here!! No need to travel anywhere..");
                    Console.WriteLine("Press 'enter' to return to Menu");
                    Console.ReadLine();
                }
                else if (Planet.currentPlanet != 2)
                {
                    Console.WriteLine("Heading to Alpha Centauri!");
                    Console.WriteLine("Distance is: {0}LYs", Math.Round(Program.Distance(Planet.GetCurX(), Planet.GetCurY(), new Menu().destX = 0, new Menu().destY = 4.367), 3));
                    Console.WriteLine("It will take you: {0}yrs", V.timePassage = Math.Round(Program.Distance(Planet.GetCurX(), Planet.GetCurY(), new Menu().destX = 0, new Menu().destY = 4.367) / Program.Velocity(Ship.ShowShipSpeed(Ship.currentShip)), 2));
                    Console.WriteLine();
                    Console.WriteLine("type 'GO' to depart");
                    Console.WriteLine("press 'enter' to go back to main menu");
                    string conf = Console.ReadLine().ToLower();

                    if (conf == "go")
                    {
                        Planet.currentPlanet = 2;
                        V.time += V.timePassage;
                        Planet.GetPlanetName(2);
                        Planet.GetCurX();
                        Planet.GetCurY();
                        Program.RandomNumbers();
                    }
                    else
                    {
                        Console.WriteLine("Returning to Menu");
                        System.Threading.Thread.Sleep(1100);
                    }

                }

                return Planet.currentPlanet;
            }

            private int Trappist()
            {
                Program.UI();
                if (Planet.currentPlanet == 3)
                {
                    Console.WriteLine("You are already here!! No need to travel anywhere..");
                    Console.WriteLine("Press 'enter' to return to Menu");
                    Console.ReadLine();
                }
                else if (Planet.currentPlanet != 3)
                {
                    Console.WriteLine("Heading to TRAPPIST-1!");
                    Console.WriteLine("Distance is: {0}LYs", Math.Round(Program.Distance(Planet.GetCurX(), Planet.GetCurY(), new Menu().destX = -3, new Menu().destY = 6), 3));
                    Console.WriteLine("It will take you: {0}yrs", V.timePassage = Math.Round(Program.Distance(Planet.GetCurX(), Planet.GetCurY(), new Menu().destX = -3, new Menu().destY = 6) / Program.Velocity(Ship.ShowShipSpeed(Ship.currentShip)), 2));
                    Console.WriteLine();
                    Console.WriteLine("type 'GO' to depart");
                    Console.WriteLine("press 'enter' to go back to main menu");
                    string conf = Console.ReadLine().ToLower();

                    if (conf == "go")
                    {
                        Planet.currentPlanet = 3;
                        V.time += V.timePassage;
                        Planet.GetPlanetName(3);
                        Planet.GetCurX();
                        Planet.GetCurY();
                        Program.RandomNumbers();
                    }
                    else
                    {
                        Console.WriteLine("Returning to Menu");
                        System.Threading.Thread.Sleep(1100);
                    }
                }

                return Planet.currentPlanet;
            }

            private int Krootabulon()
            {
                Program.UI();
                if (Planet.currentPlanet == 4)
                {
                    Console.WriteLine("You are already here!! No need to travel anywhere..");
                    Console.WriteLine("Press 'enter' to return to Menu");
                    Console.ReadLine();
                }
                else if (Planet.currentPlanet != 4)
                {
                    Console.WriteLine("Heading to Krootabulon!");
                    Console.WriteLine("Distance is: {0}LYs", Math.Round(Program.Distance(Planet.GetCurX(), Planet.GetCurY(), new Menu().destX = 10, new Menu().destY = -15), 3));
                    Console.WriteLine("It will take you: {0}yrs", V.timePassage = Math.Round(Program.Distance(Planet.GetCurX(), Planet.GetCurY(), new Menu().destX = 10, new Menu().destY = -15) / Program.Velocity(Ship.ShowShipSpeed(Ship.currentShip)), 2));
                    Console.WriteLine();
                    Console.WriteLine("type 'GO' to depart");
                    Console.WriteLine("press 'enter' to go back to main menu");
                    string conf = Console.ReadLine().ToLower();

                    if (conf == "go")
                    {
                        Planet.currentPlanet = 4;
                        V.time += V.timePassage;
                        Planet.GetPlanetName(4);
                        Planet.GetCurX();
                        Planet.GetCurY();
                        Program.RandomNumbers();
                    }
                    else
                    {
                        Console.WriteLine("Returning to Menu");
                        System.Threading.Thread.Sleep(1100);
                    }

                }

                return Planet.currentPlanet;
            }

            public void TravelMenu()
            {
                string travelInput = "";

                Program.UI();

                Console.WriteLine("Where would you like to go!!: \n" +
                                    "(Type name of planet you wish to go to)");
                Console.WriteLine("press 'Enter' to leave the space port and return to Main Menu");
                Console.WriteLine("- 'Earth' for Earth!");
                Console.WriteLine("- 'Alpha Centauri' for Alpha Centauri!");
                Console.WriteLine("- 'Trappist' for TRAPPIST-1");
                Console.WriteLine("- 'Kroot' for krootabulon!!");


                travelInput = Console.ReadLine().ToLower();
                switch (travelInput)
                {
                    case "earth":
                        Console.Clear();
                        Earth();
                        Program.UI();
                        break;
                    case "alpha centauri":
                        Console.Clear();
                        AlphaCentauri();
                        Program.UI();
                        break;
                    case "trappist":
                        Console.Clear();
                        Trappist();
                        Program.UI();
                        break;
                    case "krootabulon":
                    case "kroot":
                        Console.Clear();
                        Krootabulon();
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
    }
}
