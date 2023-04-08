using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("The cat was eating!");
        }

        public override void Sleep()
        {
            Console.WriteLine("The cat was sleeping!");
        }
    }
}
