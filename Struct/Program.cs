namespace Struct
{
    internal class Program
    {
        struct Point
        {
            public int X;
            public int Y;
            public static Point AddPoints(Point p1, Point p2)
            {
                Point result;
                result.X = p1.X + p2.X;
                result.Y = p1.Y + p2.Y;
                return result;
            }
        }
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.X = 10;
            p1.Y = 20;

            Point p2 = new Point();
            p2.X = 5;
            p2.Y = 15;

            Point result = Point.AddPoints(p1, p2);

            Console.WriteLine("Result: X = {0}, Y = {1}", result.X, result.Y);
        }
        //Основные преимущества использования структур в C#:
        //Структуры могут использоваться для хранения небольших объемов данных.
        //Структуры не могут наследоваться от других структур или классов, но могут реализовывать интерфейсы.
        //Структуры не могут иметь явных статических конструкторов.
        //Структуры не могут иметь защищенные члены, но могут иметь члены с модификатором internal.
        //Структуры не могут быть null, так как они являются значимыми типами данных.
    }
}