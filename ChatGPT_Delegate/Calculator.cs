using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPT_Delegate
{
    internal class Calculator
    {
        public delegate double BinaryOperationDelegate(double x, double y);
        public double Calculate(double x, double y, BinaryOperationDelegate operation)
        {
            return operation(x, y);
        }
        public double Multiply(double x, double y)
        {
            return x * y;
        }
        public double Plus(double x, double y)
        {
            return x + y;
        }
        public double Minus(double x, double y)
        {
            return x - y;
        }
        public double Devise(double x, double y)
        {
            return x / y;
        }
    }
}
