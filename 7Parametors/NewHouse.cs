using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Parametors
{
    internal class NewHouse:House
    {
        public NewHouse():base()
        {
            ChairType = "EUWood";
            Material = "Brick";
            DoorType = "PaternEUWood";
            LightType = "White";
            Size = "90x120";
            Price = 500000;
            SpecialColor Color = SpecialColor.Yellow;
            Console.WriteLine($"Your house color is {CYAN}{Color}{NORMAL}, size is {CYAN}{Size}{NORMAL}, your light color is {CYAN}{LightType}{NORMAL}, your door type is {CYAN}{DoorType}{NORMAL}, material is {CYAN}{Material}{NORMAL}, your chair type is {CYAN}{ChairType}{NORMAL} and your price is {CYAN}{Price}{NORMAL};");
        }
        public NewHouse(byte IDhouse):base(IDhouse)
        {
            IDhouse = 255;
            Console.WriteLine($"Your new house id is - > {IDhouse}");
        }
    }
}
