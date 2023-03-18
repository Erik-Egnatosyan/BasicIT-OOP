namespace genericAdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Fooo<dynamic>(32,55);
        }
        public static void Fooo<T>(T a, T b)
        {
            Console.WriteLine((dynamic)a + (dynamic)b);
        }
    }
}