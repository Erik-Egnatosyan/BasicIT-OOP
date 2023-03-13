using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAllPrpertyAndTest
{
    internal class Book : Product
    {
        public override void ProductsType()
        {
            Type = "Book";
            Name = "Leonel Messi";
            Category = "G.O.A.T";
            Price = 5000;
            base.ProductsType();
        }
    }
}
