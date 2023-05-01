namespace genericAdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fooo<dynamic>(32,55);
            Console.WriteLine(Sum(2, 3));
            Console.WriteLine(Sum(2.4,2.5));
            Console.WriteLine(Sum("Hello ", "World!"));
            Dictionary<dynamic, dynamic> myDictionary = new Dictionary<dynamic, dynamic>();
            myDictionary.Add("one", 1);
            myDictionary.Add(2, "two");
        }
        public static void Fooo<T>(T a, T b)
        {
            Console.WriteLine((dynamic)a + (dynamic)b);
        }
        public static T Sum<T>(T a, T b)
        {
            return (dynamic)a + (dynamic)b;
        }
    }
}