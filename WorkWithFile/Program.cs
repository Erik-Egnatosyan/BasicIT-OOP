using System.IO;

namespace WorkWithFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Erik\Desktop\example.txt";
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine("You have file");
            }
            else
            {
                File.Create(filePath).Dispose();
                Console.WriteLine("You dont have it. I created for you");
            }
            string json = "{\"name\":\"John\", \"age\":30, \"car\":Bmw}";
            File.WriteAllText(filePath, json + Environment.NewLine);
            Console.WriteLine("Do you want to see 1)Pretty version or 2)Original?");
            int inputOneOrTwo = Convert.ToInt32(Console.ReadLine());
            if (inputOneOrTwo == 1)
            {
                string[] jsonReader = File.ReadAllText(filePath).Split(",");
                for (int i = 0; i < jsonReader.Length; i++)
                {
                    jsonReader[i] = jsonReader[i].Replace("{", "").Replace("}", "");
                    Console.WriteLine(jsonReader[i]);
                }
            }
            else if (inputOneOrTwo == 2)
                Console.WriteLine(File.ReadAllText(filePath));
            Console.WriteLine("Do you want delite file?\n1)Yes\n2)No");
            inputOneOrTwo = Convert.ToInt32(Console.ReadLine());
            if (inputOneOrTwo == 1)
            {
                Console.WriteLine($"I delited your file");
                File.Delete(filePath);
            }
            else if (inputOneOrTwo == 2)
                Console.WriteLine("Okay i keep it ;3");
        }
    }
}