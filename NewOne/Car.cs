using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOne
{
    internal class Car
    {
        public string color {  get; set; }
        public string name { get; set; }
        public int WheelsSize { get; set; }
        public int CarSize { get; set; }
        public Car()
        {
            color = "red";
            WheelsSize = 10;
        }
        public Car(long id)
        {
            id = 7844558;
        }
    }
}
