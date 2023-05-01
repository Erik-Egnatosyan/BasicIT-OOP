using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Создаем новый поток
        Thread myThread = new Thread(MyMethod);
        // Запускаем выполнение потока
        myThread.Start();

        // Выполнение метода в основном потоке
        for (int i = 0; i < 50; i++)
        {
            Console.WriteLine("Главный поток:");
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
        Console.ReadLine();
    }

    static void MyMethod()
    {
        // Выполнение метода в новом потоке
        for (int i = 0; i < 50; i++)
        {
            Console.WriteLine("Дополнительный поток:");
            Console.WriteLine(i);
            Thread.Sleep(500);
        }
    }
}
