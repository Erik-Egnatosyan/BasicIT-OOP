using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewExampleOfInterface
{
    internal interface IMovable
    {
        string Name { get; set; }
        string Doing { get; set; }
        void Move()
        {
            Console.WriteLine($"{Name} is {Doing}");
        }
    }
}
