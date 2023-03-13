using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Parametors
{
    internal class OldHouse:House
    {
        public OldHouse():base()
        {
            ChairType = "Wood";
            Material = "Metal";
            DoorType = "Wood";
            LightType = "White";
            Size = "40x50";
            Price = 70000;
            SpecialColor Color = SpecialColor.Blue;
            Console.WriteLine($"Your house color is {CYAN}{Color}{NORMAL}, size is {CYAN}{Size}{NORMAL}, your light color is {CYAN}{LightType}{NORMAL}, your door type is {CYAN}{DoorType}{NORMAL}, material is {CYAN}{Material}{NORMAL}, your chair type is {CYAN}{ChairType}{NORMAL} and your price is {CYAN}{Price}{NORMAL};");
        }
        public OldHouse(byte IDhouse):base(IDhouse)
        {
            IDhouse = 100;
            Console.WriteLine($"Your old house id is -> {IDhouse}");
        }
    }
}
