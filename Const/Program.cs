namespace Const
{
    internal class Program
    {
        const int daysInWeek = 7;
        const string greeting = "Hello, World!";
        readonly int number = 5;
        public static void Method1(int number)
        {
            Console.WriteLine(number);
        }
        static void Main(string[] args)
        {
            Method1(25);
        }

        //Свойства у const следующие:
        //1)Нельзя изменять значение переменной после её объявления и инициализации.
        //2)Переменная доступна только для чтения.
        //3)Значение переменной должно быть вычислено во время компиляции,
        //поэтому её нельзя инициализировать во время выполнения программы.
        //4)Переменные const должны быть проинициализированы в той же строке, где они объявлены.
    }
}