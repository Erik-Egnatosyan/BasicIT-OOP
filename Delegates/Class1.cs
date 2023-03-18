using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Class1
    {
        public int Method1(int x) 
        { 
            x = 5000; return x; 
        }
        public int Method2(int x) {
            return x - 500; }
        public int Method3(int x) { 
            return x + 300; }
        public delegate int MDel(int x);
    }
}
