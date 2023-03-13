using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAllPrpertyAndTest
{
    internal class Truck:Car
    {
        public override void Ride(int speed)
        {
            base.Ride(speed * 2);
        }
    }
}
