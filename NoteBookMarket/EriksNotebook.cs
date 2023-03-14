using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookMarket
{
    internal class EriksNotebook : INotebook
    {
        public string Brand { get; set; }
        public string SubBrand { get; set; }
        public double Weight { get; set; }
        public byte Ram { get; set; }
        public int count { get; set; }

        public void FirstAcceleration()
        {
            Console.Write("Brand   " + Brand);
            Console.WriteLine(" EriksNotebook : INotebook++   FirstAcceleration");
        }

        void INotebook.SecondAcceleration(int t) {
            Console.WriteLine(t);
        }
    }
}
