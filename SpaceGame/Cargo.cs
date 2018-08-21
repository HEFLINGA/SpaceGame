using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Cargo
    {
       
        
        //int cargo = (0);
        //int cargoFood = 1;//2000
        //int cargoResearch =1;//3000
        //in//t cargoAnimal = 1;//4000
        //int cargoWater = 2;//5000
        //int cargoFuel = 2;//6000

 

        


    }
    class Test
    {


        public string Type { get; set; }
        public int Size { get; set; }
        public int Cost { get; set; }

        static void Main(string[] args)
        {

  
            Cargo myCargo = new Cargo();
            myCargo.Type = "Food";
            myCargo.Size = 1;
            myCargo.Cost = 2000;

            Cargo myCargo2 = new Cargo();
            myCargo2.Type ="Research";
            myCargo2.Size=1;
            myCargo2.Cost = 3000;

            Cargo myCargo3 = new Cargo();
             myCargo3.Type="Animal";
            myCargo3.Size=1;
            myCargo3.Cost=4000;


            Cargo myCargo4 = new Cargo();
            myCargo4.Type="Water";
            myCargo4.Size=2;
            myCargo4.Cost=5000;

            Cargo myCargo5 = new Cargo();
            myCargo5.Type="Fuel";
            myCargo5.Size=2;
            myCargo5.Cost=4000M;

            Console.WriteLine("{0}{1}{2} ",
            myCargo.Type,
            myCargo.Size,
            myCargo.Cost);
            Console.ReadLine();

        }

    
        


    }







}
        





    

