using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map
{
    internal class Francia : ICountry, IT
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public int Population { get; set; }
        public string Continent { get; set; }
        public string Creature { get; set; }
        public string Power { get; set; }
        public int GeniusPrcent { get; set; }
        public int GenderPrcent { get; set; }
        public Francia()
        {
            Name = "Francia";
            Size = 45000000;
            Population = 42000000;
            Continent = "Europ";
            Creature = "01.05.1745";
            Power = "Epic";
            GeniusPrcent = 85;
            GenderPrcent = 10;
        }
    }
}
