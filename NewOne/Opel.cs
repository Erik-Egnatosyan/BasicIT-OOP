using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOne
{
    internal class Opel:Car
    {
        public Opel():base()
        {
            color = "Green";
            name = "Zafira";
            WheelsSize = 12;
            CarSize = 6;
        }
        public Opel(long id):base(id)
        {
            id = 77788899;
        }
    }
}
