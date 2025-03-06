using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game2
{
    abstract class Item
    {
        public string Name { get; set; }
    }
    class Rope : Item //předměty v inventáři
    {
        public Rope()
        {
            Name = "Lano";
        }
    }
    class Map : Item
    {
        public Map()
        {
            Name = "Mapka";
        }
    }
    class Weapon : Item
    {
        public Weapon()
        {
            Name = "Zbraň";
        }
    }
}
