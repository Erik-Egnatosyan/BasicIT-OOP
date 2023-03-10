namespace NewOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bmw bmw = new Bmw();
            Bmw bmw1 = new Bmw(5);
            Opel opel = new Opel();
            Console.WriteLine(opel.name);
            Console.WriteLine(bmw.color);
        }
    }
}