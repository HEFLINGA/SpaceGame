﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Program
    {
        
        public static bool GameOver(double money, double time)
        {
            bool gameOver = false;
            if ((money <= 0) || (time >= 40))
            {
                gameOver = true;
            }
            else
            {
                gameOver = false;
            }

            return gameOver;
        }

        /*
        public static double TimePassage(double distance)
        {
            double totalTime = 40;
            double currentTime = 0;

            while (currentTime < totalTime)
            {
                if (distance > 0)
                {
                    currentTime += distance;
                    return currentTime;
                }
            }            

            return currentTime;
        }
        */



        public static double Distance(double LocationX, double LocationY)
        {
            //double distance = 0;
            //distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            //return distance;

            //Calculate the distance between the both points
            //for both axes separately.
            double curLocation = Math.Abs(LocationX - cordX);
            double desLocation = Math.Abs(LocationY - cordY);

            //Calculate the length of a line traveling from pt1 to pt2
            //(according to Pythagoras).
            double dblHypotenuseLength = Math.Sqrt(
               LocationX * dblDistX
               +
               LocationY * dblDistY);

               return dblHypotenuseLength;
        }



        static void Main(string[] args)
        {
            // Intro line and story
            Console.WriteLine("Welcome to SpaceGame!!");
            Console.WriteLine();
            Console.WriteLine("  The year is 3018.A guy a guy or girl of your choice relative passed and left them 10000 dollars. Their family use to be rich merchants but " +
                "feel on hard time.They always had a dream of becoming a space ship captain to try to restore their family's name and wealth. ");
            Console.ReadLine();

            // string decleration
            string input;
            string shopInput;
            string currentLocation = "Earth";


            // int decleration
            int shipCargoMax = 3;
            int shipCargoCurrent = 0;
            int cost = 0;
            int credits = 10000;          

            // double decleration
            double speed = 0;
            double distance = 0;
            double time = 0;

            // bool decleration
            

            // Ship instantiation
            Ship tier1 = new Ship();
            tier1.Name = "RustBucket";
            tier1.Speed = 3;
            tier1.Price = 5000;
            tier1.Cargo = 2;

            Ship tier2 = new Ship();
            tier2.Name = "Speedyy";
            tier2.Speed = 4;
            tier2.Price = 15000;
            tier2.Cargo = 4;

            Ship tier3 = new Ship();
            tier3.Name = "USS Schwifty Ship";
            tier3.Speed = 6;
            tier3.Price = 30000;
            tier3.Cargo = 6;


            // Cargo instantiation            

            Cargo food = new Cargo();
            food.Type = "Food";
            food.Size = 1;
            food.Cost = 2000;
            food.Speed = -.5;
            

            Cargo research = new Cargo();
            research.Type = "Research";
            research.Size = 1;
            research.Cost = 3000;
            research.Speed = -.5;


            Cargo animal = new Cargo();
            animal.Type = "Animal";
            animal.Size = 1;
            animal.Cost = 4000;
            animal.Speed = -.5;
            
            Cargo water = new Cargo();
            water.Type = "Water";
            water.Size = 2;
            water.Cost = 5000;
            water.Speed = -1;
            
            Cargo fuel = new Cargo();
            fuel.Type = "Fuel";
            fuel.Size = 2;
            fuel.Cost = 6000;
            fuel.Speed = -1;

            // Planet Instantiation

            Planet myPlanet = new Planet();
            myPlanet.Type = "EARTH";
            myPlanet.Date = time;
            myPlanet.Rate = 1.00;
            myPlanet.LocationX = 0;
            myPlanet.LocationY = 0;

            Planet myPlanet2 = new Planet();
            myPlanet2.Type = "TRAPPIST-1";
            myPlanet2.Date = time;
            myPlanet2.Rate = (1.00 - 0.86) / 0.86 * 100.00;
            myPlanet2.Location = 10;


            Planet myPlanet3 = new Planet();
            myPlanet3.Type = "ALPHA CENTAURI";
            myPlanet3.Date = time;
            myPlanet3.Rate = (1.00 - 3.79) / 3.709 * 100.00;
            myPlanet3.Location = 4.67;
            



            Console.Clear();
            Console.WriteLine("Enter your name, adventurer!");
            string character = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Welcome {0}, to the SPACE GAAMMMEEEEE(Click 'Enter' to continue)", character);
            Console.ReadLine();

            // Console
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.SetCursorPosition(30, 1);
            Console.WriteLine("Cargo: {0}/{1}", shipCargoCurrent, shipCargoMax);
            Console.SetCursorPosition(5, 1);
            Console.WriteLine("Name: {0}", character);
            Console.SetCursorPosition(55, 1);
            Console.WriteLine("Credits: {0}", credits);
            Console.SetCursorPosition(90, 1);
            Console.WriteLine("Time: {0}", time);
            Console.WriteLine("________________________________________________________________________________________________________________________");

            // Buy your ship
            // TODO - Add ships description and price
            Console.Clear();
            // Console
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.SetCursorPosition(30, 1);
            Console.WriteLine("Cargo: {0}/{1}", shipCargoCurrent, shipCargoMax);
            Console.SetCursorPosition(5, 1);
            Console.WriteLine("Name: {0}", character);
            Console.SetCursorPosition(55, 1);
            Console.WriteLine("Credits: {0}", credits);
            Console.SetCursorPosition(90, 1);
            Console.WriteLine("Time: {0}", time);
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.WriteLine("Buy your first ship! Type \"Purchase\" to complete the transaction: ");

            // Get input from console to select ship and purchase
            // TODO - Connect money and currancy to prices of ships
            // TODO - Connect ships to cases
            input = Console.ReadLine();

            switch (input)
            {
                case "Purchase":
                case "1":
                case "purchase":
                    cost = 5000;
                    credits -= tier1.Price;
                    shipCargoMax = tier1.Cargo;
                    speed = tier1.Speed;
                    break;
                default:
                    Console.Write("Well, it was nice knowin' you! Your days on a ship have ended before they began..");

                    break;
            }

            if (cost != 0)
            {
                Console.WriteLine("You paid {0} for your ship!!", cost);
                Console.WriteLine();
                Console.WriteLine("Thank you for shopping with SpaceBuggies R Us");
            }

            Console.Clear();
            Console.WriteLine("\n Your first ship!! The {0}. Speed: {1}. Cargo Space: {2}", tier1.Name, tier1.Speed, tier1.Cargo);
            Console.ReadLine();
            Console.Clear();

            // Player starts his journey exploring and buying

            do
            {
                // Console
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.SetCursorPosition(30, 1);
                Console.WriteLine("Cargo: {0}/{1}", shipCargoCurrent, shipCargoMax);
                Console.SetCursorPosition(5, 1);
                Console.WriteLine("Name: {0}", character);
                Console.SetCursorPosition(55, 1);
                Console.WriteLine("Credits: {0}", credits);
                Console.SetCursorPosition(90, 1);
                Console.WriteLine("Time: {0}", time);
                Console.WriteLine("________________________________________________________________________________________________________________________");

                //Console.WriteLine("You are on planet {0}! Currency is the {1}, current date/time is {2}. Earth has a {3} focused economy!", , , ,);
                Console.WriteLine("You are on planet {0}! Currency is the USD, current year is {1}.!",
                    myPlanet.Type, myPlanet.Date);
                Console.WriteLine();
                Console.WriteLine("What would you like to do?: (Type 'Upgrade' to upgrade your ship, 'Buy' to buy goods, 'Sell' to sell goods, or travel to leave and go to the next planet!)");

                // Planetary options
                shopInput = Console.ReadLine();
                //Console.ReadLine();

                if ((shopInput != "travel") || (shopInput != "Travel"))
                {
                        if ((shopInput == "Buy") || (shopInput == "buy"))
                        {
                            Console.WriteLine("What would you like to buy?");
                            Console.WriteLine("press 'Enter' to leave the trading post");
                            Console.WriteLine("{0}, price: {1}", food.Type, (food.Cost));
                            Console.WriteLine("{0}, price: {1}", research.Type, (research.Cost));
                            Console.WriteLine("{0}, price: {1}", animal.Type, (animal.Cost));
                            Console.WriteLine("{0}, price: {1}", water.Type, (water.Cost));
                            Console.WriteLine("{0}, price: {1}", fuel.Type, (fuel.Cost));
                          
                                string buyInput = Console.ReadLine();
                            switch (buyInput)
                            {
                                case "Food":
                                case "food":
                                    Console.Clear();
                                    credits -= food.Cost;
                                    Console.SetCursorPosition(0, 0);
                                    Console.WriteLine("________________________________________________________________________________________________________________________");
                                    Console.SetCursorPosition(30, 1);
                                    Console.WriteLine("Cargo: {0}/{1}", shipCargoCurrent, shipCargoMax);
                                    Console.SetCursorPosition(5, 1);
                                    Console.WriteLine("Name: {0}", character);
                                    Console.SetCursorPosition(55, 1);
                                    Console.WriteLine("Credits: {0}", credits);
                                    Console.SetCursorPosition(90, 1);
                                    Console.WriteLine("Time: {0}", time);
                                    Console.WriteLine("________________________________________________________________________________________________________________________");
                                    //Console.ReadLine();
                                    break;
                                case "Research":
                                case "research":
                                    Console.Clear();
                                    credits -= research.Cost;
                                    Console.SetCursorPosition(0, 0);
                                    Console.WriteLine("________________________________________________________________________________________________________________________");
                                    Console.SetCursorPosition(30, 1);
                                    Console.WriteLine("Cargo: {0}/{1}", shipCargoCurrent, shipCargoMax);
                                    Console.SetCursorPosition(5, 1);
                                    Console.WriteLine("Name: {0}", character);
                                    Console.SetCursorPosition(55, 1);
                                    Console.WriteLine("Credits: {0}", credits);
                                    Console.SetCursorPosition(90, 1);
                                    Console.WriteLine("Time: {0}", time);
                                    Console.WriteLine("________________________________________________________________________________________________________________________");
                                    break;
                                case "animal":
                                case "Animal":
                                    Console.Clear();
                                    credits -= research.Cost;
                                    Console.SetCursorPosition(0, 0);
                                    Console.WriteLine("________________________________________________________________________________________________________________________");
                                    Console.SetCursorPosition(30, 1);
                                    Console.WriteLine("Cargo: {0}/{1}", shipCargoCurrent, shipCargoMax);
                                    Console.SetCursorPosition(5, 1);
                                    Console.WriteLine("Name: {0}", character);
                                    Console.SetCursorPosition(55, 1);
                                    Console.WriteLine("Credits: {0}", credits);
                                    Console.SetCursorPosition(90, 1);
                                    Console.WriteLine("Time: {0}", time);
                                    Console.WriteLine("________________________________________________________________________________________________________________________");
                                    break;
                                case "water":
                                case "Water":
                                    Console.Clear();
                                    credits -= water.Cost;
                                    Console.SetCursorPosition(0, 0);
                                    Console.WriteLine("________________________________________________________________________________________________________________________");
                                    Console.SetCursorPosition(30, 1);
                                    Console.WriteLine("Cargo: {0}/{1}", shipCargoCurrent, shipCargoMax);
                                    Console.SetCursorPosition(5, 1);
                                    Console.WriteLine("Name: {0}", character);
                                    Console.SetCursorPosition(55, 1);
                                    Console.WriteLine("Credits: {0}", credits);
                                    Console.SetCursorPosition(90, 1);
                                    Console.WriteLine("Time: {0}", time);
                                    Console.WriteLine("________________________________________________________________________________________________________________________");
                                    break;
                                case "fuel":
                                case "Fuel":
                                    Console.Clear();
                                    credits -= fuel.Cost;
                                    Console.SetCursorPosition(0, 0);
                                    Console.WriteLine("________________________________________________________________________________________________________________________");
                                    Console.SetCursorPosition(30, 1);
                                    Console.WriteLine("Cargo: {0}/{1}", shipCargoCurrent, shipCargoMax);
                                    Console.SetCursorPosition(5, 1);
                                    Console.WriteLine("Name: {0}", character);
                                    Console.SetCursorPosition(55, 1);
                                    Console.WriteLine("Credits: {0}", credits);
                                    Console.SetCursorPosition(90, 1);
                                    Console.WriteLine("Time: {0}", time);
                                    Console.WriteLine("________________________________________________________________________________________________________________________");
                                    break;
                                default:
                                Console.WriteLine("Returning to Menu");
                                System.Threading.Thread.Sleep(3000);
                                    break;

                            }
                        }
                }

            } while (GameOver(credits, time) == false);
            // Game over
            Console.WriteLine("Game Over!! Total play time: {0}.  Total credits: {1}", time, credits);
            Console.ReadLine();
        }
    }
}
