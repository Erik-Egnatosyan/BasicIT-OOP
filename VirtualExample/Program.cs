namespace VirtualExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass obj1 = new BaseClass();
            DerivedClass obj2 = new DerivedClass();

            Console.WriteLine(obj1.GetMyProperty());
            Console.WriteLine(obj2.GetMyProperty());
        }
    }
}