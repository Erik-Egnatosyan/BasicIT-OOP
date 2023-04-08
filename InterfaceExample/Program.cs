namespace InterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape shape;
            shape = new Circle(5);
            Console.WriteLine("Circle area: " + shape.GetArea());

            shape = new Rectangle(10, 5);
            Console.WriteLine("Rectangle area: " + shape.GetArea());
        }
    }
}