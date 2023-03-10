using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Parametors
{

    internal class House
    {
        public string NORMAL = Console.IsOutputRedirected ? "" : "\x1b[39m";
        public string CYAN = Console.IsOutputRedirected ? "" : "\x1b[96m";
        public string ChairType { get; set; }
        public string Material { get; set; }
        public string DoorType { get; set; }
        public string LightType { get; set; }
        public string Size { get; set; }
        public int Price { get; set; }
        public enum SpecialColor
        {
            Yellow = 0,
            Green = 1,
            Blue = 2,
            Purple = 3,
            White = 4,
            Violet = 5
        }
        public House()
        {
            ChairType = "Wood";
            Material = "brick";
            DoorType = "EUWood";
            LightType = "Yellow";
            Size = "30x50";
            Price = 50000;
            SpecialColor white = SpecialColor.White;
        }
        public House(byte IDhouse)
        {
            IDhouse = 124;      
        }
    }
    
}
