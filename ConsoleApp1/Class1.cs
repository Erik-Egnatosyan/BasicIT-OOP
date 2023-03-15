using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        public int a = 5;
#pragma warning disable CS0414 // Полю "Class1.b" присвоено значение, но оно ни разу не использовано.
        private int b = 5;
#pragma warning restore CS0414 // Полю "Class1.b" присвоено значение, но оно ни разу не использовано.
        protected int c = 5;
        internal int d = 5;
        protected internal int e = 5;
        internal protected int f = 5;
    }
}
