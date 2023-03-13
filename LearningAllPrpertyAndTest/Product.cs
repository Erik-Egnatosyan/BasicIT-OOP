using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAllPrpertyAndTest
{
    internal class Product
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public virtual void ProductsType()
        {
            Console.WriteLine($"Your {Type} name is {Name}. The category is {Category} and price is {Price};");
        }
    }
}
