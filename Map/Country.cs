using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map
{
    internal interface ICountry
    {
        string Name { get; set; }
        int Size { get; set; }
        int Population { get; set; }
        string Continent { get; set; }
        string Creature { get; set; }
    }
}
