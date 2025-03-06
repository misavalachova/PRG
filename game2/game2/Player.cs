using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game2
{
    internal class Player
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public List<Item> Inventory { get; set; }

        public Player(string name)
        {
            Name = name;
            Health = 150;
            Inventory = new List<Item>(); //seznam přdmětů, které hráč vlastní, odkaz na třídu item
        }
    }
}
