using System.IO;

namespace WorkWithFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Eriksson\Desktop\example.txt";
            File.Create(filePath);
            File.Exists(filePath);
        }
    }
}