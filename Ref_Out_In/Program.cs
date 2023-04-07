namespace Ref_Out_In
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---REF---");
            Ref_Example();
            Console.WriteLine("---OUT---");
            Out_Example();
            Console.WriteLine("---IN---");
            In_Example();
        }
        //-----------------------------------------REF--------------------------------------------
        //Напишите метод FindMax, который принимает массив целых чисел по ссылке (используя ключевое слово ref) и возвращает максимальное значение в массиве. Метод не должен использовать стандартные функции для поиска максимального значения (например, Max()).
        public static void Ref_Example()
        {
            int[] array = { 3, 7, 1, 9, 4 };
            Console.WriteLine("Исходный массив: ");
            foreach (int i in array) { Console.WriteLine(i); }

            int max1 = FindMax(ref array);
            Console.WriteLine($"Максимальное значение: {max1}");

            Console.WriteLine("Измененный массив: ");
            foreach (int i in array) { Console.WriteLine(i); }
            int max2 = FindMax(ref array);
            Console.WriteLine($"Максимальное значение: {max2}");
        }

        public static int FindMax(ref int[] ints)
        {
            int max = ints[0];
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] > max)
                {
                    max = ints[i];
                }
            }
            ints[0] = 100;
            // изменяем массив внутри метода
            return max;
        }
        //-----------------------------------------OUT--------------------------------------------
        //Напишите метод Divide, который принимает два целочисленных значения и возвращает их частное и остаток в виде out параметров. Если делитель равен нулю, метод должен вернуть значение false, иначе - true. Используйте out для возврата нескольких значений из метода.
        public static void Out_Example()
        {
            int dividend = 20;
            int divisor = 3;
            int quotient, remainder;
            bool result = Divide(dividend, divisor, out quotient, out remainder);

            if (result)
            {
                Console.WriteLine($"{dividend} / {divisor} = {quotient}, остаток: {remainder}");
            }
            else
            {
                Console.WriteLine("Деление на ноль невозможно");
            }
        }
        public static bool Divide(int num1, int num2, out int check1, out int check2)
        {
            check1 = 0;
            check2 = 0;
            if (num1 == 0 || num2 == 0)
                return false;
            else
            {
                check1 = num1 / num2;
                check2 = num1 % num2;
            }
            return true;
        }
        //-----------------------------------------IN--------------------------------------------
        //Напишите метод GetPositiveNumbers, который принимает массив целых чисел типа int[] в качестве параметра и возвращает новый массив, содержащий только положительные числа из исходного массива. В методе должно использоваться ключевое слово in для передачи параметра только для чтения.
        public static void In_Example()
        {
            int[] numbers = { 1, -2, 3, -4, 5 };
            int[] positiveNumbers = GetPositiveNumbers(numbers);
            foreach (var item in positiveNumbers)
            {
                Console.WriteLine(item);
            }
        }
        public static int[] GetPositiveNumbers(in int[] numbers)
        {
            int[] positiveNumbers = new int[numbers.Length];
            int index = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 0)
                {
                    positiveNumbers[index] = numbers[i];
                    index++;
                }
            }
            Array.Resize(ref positiveNumbers, index);
            return positiveNumbers;
        }
    }
}