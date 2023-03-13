using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAllPrpertyAndTest
{
    internal class Movie : Product
    {
        public override void ProductsType()
        {
            Type = "Movie";
            Name = "Barcelona";
            Category = "Horror";
            Price = 10;
            base.ProductsType();
        }
    }
}
