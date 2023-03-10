namespace _7Parametors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NewHouse newHouse = new NewHouse();
            OldHouse oldHouse = new OldHouse();
            NewHouse newHouse2 = new NewHouse(1);
            OldHouse oldHouse2 = new OldHouse(1);
        }
    }
}