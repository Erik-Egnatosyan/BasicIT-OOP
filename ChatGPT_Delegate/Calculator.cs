using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPT_Delegate
{
    internal class Calculator
    {
        // Определение делегата, принимающего два параметра типа double и возвращающего значение double
        public delegate double BinaryOperationDelegate(double x, double y);
        // Метод Calculate, принимающий два параметра типа double и экземпляр делегата BinaryOperationDelegate
        public double Calculate(double x, double y, BinaryOperationDelegate operation)
        {
            // Вызов метода, переданного через делегат operation, с переданными параметрами x и y, и возвращение результата
            return operation(x, y);
        }
        // Метод Multiply, выполняющий умножение двух чисел
        public double Multiply(double x, double y)
        {
            return x * y;
        }

        // Метод Plus, выполняющий сложение двух чисел
        public double Plus(double x, double y)
        {
            return x + y;
        }

        // Метод Minus, выполняющий вычитание двух чисел
        public double Minus(double x, double y)
        {
            return x - y;
        }

        // Метод Devise, выполняющий деление двух чисел
        public double Devise(double x, double y)
        {
            return x / y;
        }
    }
}
