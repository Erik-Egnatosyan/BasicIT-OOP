using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DleiveryProj
{
    internal interface IDelivery
    {
        public int ShipTime { get; set; }
        public long TrackId { get; set; }
        public decimal ShipCost { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Sale { get; set; }
    }
}
