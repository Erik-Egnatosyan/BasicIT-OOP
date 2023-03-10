using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOne
{
    internal class Bmw:Car
    {
        public long Id { get; set; }
        public Bmw():base()
        {
            color = "Yellow";
            Console.WriteLine(color);
            name = "M4";
            WheelsSize = 12;
            CarSize = 6;
        }
        public Bmw(long id):base(id)
        {
            Id = id;
            Console.WriteLine(Id);
        }
    }
}
