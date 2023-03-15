namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.WriteLine(class1.a);
            //Console.WriteLine(class1.b);
            //Console.WriteLine(class1.c);
            Console.WriteLine(class1.d);
            Console.WriteLine(class1.e);
            Console.WriteLine(class1.f);
#pragma warning disable CS0464 // Сравнение со значением NULL или типом структуры всегда вызывает false
            bool bro = null >= 0;
#pragma warning restore CS0464 // Сравнение со значением NULL или типом структуры всегда вызывает false
            Console.WriteLine(bro);
        }
    }
}