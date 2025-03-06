using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game2
{
    internal class Location
    {
        public string Name { get; set; }
        public List<Event> Events { get; set; }

        public Location(string name, List<Event> events)
        {
            Name = name;
            Events = events;
        }

        public Event GetRandomEvent() //vybere náhodnou událost podle vybrané lokace
        {
            Random random = new Random();
            return Events[random.Next(Events.Count)]; // count dostane počet věcí v seznamu
        }
    }
}
