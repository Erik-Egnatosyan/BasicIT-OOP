using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DleiveryProj
{
    internal interface ITransport : IDelivery
    {
        public int MaxWeight { get; }
        public int MinWeight { get; }
        public Loaction LoactionDelivery { get; set; }
        public enum Loaction
        {
            Armenia,
            Georgia,
            Germany,
            France,
            Argentina,
            Portugal,
            Slovenia
        }
        public void Checker();
    }
}
