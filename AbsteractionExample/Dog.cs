using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsteractionExample
{
    internal class Dog : Animal
    {
        public override string Speak()
        {
            return "Woof!";
        }
    }
}
