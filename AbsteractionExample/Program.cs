using AbsteractionExample;

namespace AbstractionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Console.WriteLine(cat.Speak());
        }
    }
}