using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Item
    {
       
        public string Name { get; set; }
        public int Cost { get; set; }
        public int Space { get; set; }

        public static Item food = new Item()
        {
            Name = "Food",
            Cost = 2000,
            Space = 1
        };

        public static Item research = new Item()
        {
            Name = "Research",
            Cost = 3000,
            Space = 1
        };

        public static Item animals = new Item()
        {
            Name = "Animals",
            Cost = 4000,
            Space = 1
        };

        public static Item water = new Item()
        {
            Name = "Water",
            Cost = 5000,
            Space = 2
        };

        public static Item fuel = new Item()
        {
            Name = "Fuel",
            Cost = 6000,
            Space = 2
        };

    }
}
