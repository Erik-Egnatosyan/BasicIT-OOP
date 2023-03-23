namespace DictionaryExample
{
    using System.Collections;
    using System.Diagnostics;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();
            numberList.Add(1);
            numberList.Add(2);
            numberList.Add(3);
            numberList.Add(4);
            numberList.Add(5);
            Dictionary<string,string> keyValuePairs = new Dictionary<string,string>();
            keyValuePairs.Add("Erik", "Egnatosyan");
            keyValuePairs.Add("Georgi", "Pogosyan");
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "e");
            hashtable.Add(2, "r");
            hashtable.Add(3, "i");
            hashtable.Add(4, "k");
            foreach (int i in numberList)
            {
                Console.Write(i);
            }

            Console.WriteLine();

            foreach (var number in keyValuePairs)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            foreach (var item in hashtable)
            {
                Console.WriteLine(item);
            }
        }
    }
}