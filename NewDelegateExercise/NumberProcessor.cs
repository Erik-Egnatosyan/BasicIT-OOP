using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDelegateExercise
{
    internal class NumberProcessor
    {
        public delegate int[] OddOrEven(int[] number);
        public int[] MyInts(int[] number, OddOrEven Checker)
        {
            return Checker(number);
        }
        public int[] OddNumber(int[] number)
        {
            int[] ints = new int[number.Length];
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 1)
                {
                    ints[i] = number[i];
                    Console.Write($"{ints[i]} ");
                }
                    
            }
            return ints;
        }
        public int[] EvenNumber(int[] number)
        {
            int[] ints = new int[number.Length];
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 0)
                {
                    ints[i] = number[i];
                    Console.Write($" {ints[i]} ");
                }    
            }
            return ints;
        }
    }
}
