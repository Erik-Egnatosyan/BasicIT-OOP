using System.Text.Unicode;
using System.Text;

namespace TEst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello, world!";
            byte[] utf8Bytes = Encoding.UTF8.GetBytes(str);

            int offset;
            int length;
            Utf8.GetOffsetAndLength(utf8Bytes, out offset, out length);

            Console.WriteLine($"Смещение: {offset}, Длина: {length}");

        }
    }
}