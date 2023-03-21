using System.Linq;
using System.Text;

namespace Test1231234
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "D1rt9";
            str = string.Join(" ", str.ToCharArray());
            for (int i = 0; i < str.Length; i++)
            {
                if (!(Char.IsLetter(str[i])) && str[i] != ' ')
                {
                    str = str.Remove(i - 1, 1);
                }
               else if (!(Char.IsLetter(str[i])) && Char.IsLetter(str[i + 1]) && i != str.Length)
                    str = str.Remove(i, 1);
            }
            Console.WriteLine("This is str\n" + str);
        }
    }
}