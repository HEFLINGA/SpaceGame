using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Planet
    {

        public string Type { get; set; }
        public string Date { get; set; }
        public decimal Cost { get; set; }


            Planet myPlanet = new Planet();
            myPlanet.Type = "EARTH";
            myPlanet.Date = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            myPlanet.Cost = 1.00;

            Planet myPlanet2 = new Planet();
            myPlanet.Type="TRAPPIST-1";
            myPlanet.Date= System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"+6);
            myPlanet.Cost= (1.00 - 0.86)/0.86 * 100.00
            
            Planet myPlanet3 = new Planet();
            myPlanet.Type="ALPHA CENTAURI";
            myPlanet.Date=System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"+8.5);
            myPlanet.Cost= (1.00 - 3.79)/3.709 * 100.00
            
    }        
}
