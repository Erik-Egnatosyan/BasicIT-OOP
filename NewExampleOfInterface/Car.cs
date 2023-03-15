using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewExampleOfInterface
{
    internal class Car : IMovable
    {
        public string Name { get; set; }
        public string Doing { get; set; }
        public void Move()
        {
            Console.WriteLine($"{Name} is {Doing}");
        }
    }
}
