using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualExample
{
    internal class DerivedClass : BaseClass
    {
        private int myPropertyValue = 99;

        public override int GetMyProperty()
        {
            return myPropertyValue;
        }
    }
}
