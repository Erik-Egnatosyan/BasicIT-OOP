namespace StaticExample
{
    class Myclass
    {
        private static int a;

        private int b;

        public static void StaticMethod()
        {
            Console.WriteLine("This is static method");
            a = 1;
            //b = 2; Ошибка -> В Методе со статическими нельзя исползовать нестатические
        }

        public void NotStaticMethod()
        {
            Console.WriteLine("This is not static method");
            a = 1;
            b = 2; //Всё ок. Можно исползовать и статические и не сатические
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Myclass myclass = new Myclass(); // Создаем экземпляр класса
            myclass.NotStaticMethod(); //Это если метод не статический
            Myclass.StaticMethod(); //Это если метод статический
        }
    }
}