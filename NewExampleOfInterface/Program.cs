namespace NewExampleOfInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Plane plane = new Plane();
            car.Name = "Car";
            car.Doing = "riding";
            car.Move();
        }
    }
}