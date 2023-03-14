using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map
{
    internal class Germany : ICountry, IT
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public int Population { get; set; }
        public string Continent { get; set; }
        public string Creature { get; set; }
        public string Power { get; set; }
        public int GeniusPrcent { get; set; }
        public int GenderPrcent { get; set; }
        public Germany()
        {
            Name = "Germania";
            Size = 83000000;
            Population = 42000000;
            Continent = "Europ";
            Creature = "01.05.1765";
            Power = "Epic";
            GeniusPrcent = 15;
            GenderPrcent = 78;
        }
    }
}
