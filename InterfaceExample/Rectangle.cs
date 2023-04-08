using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class Rectangle : IShape
    {
        private double width;
        private double height;
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public double GetArea()
        {
            return width * height;
        }
    }
}
