using System.Linq;
using System.Text;

namespace Test1231234
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "TOmorrow    cOMes              TodAY";
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                output += input[i];
                if (i != input.Length - 1 && char.IsLetter(input[i]) && char.IsLetter(input[i + 1]))
                {
                    output += " ";
                }
            }
            Console.WriteLine(output);
        }
    }
}