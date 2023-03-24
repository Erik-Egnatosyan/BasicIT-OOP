namespace ExampleOfDictQueStackList
{
    using System.Collections;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>(); //List
            numberList.Add(1);
            numberList.Add(2);
            numberList.Add(3);
            numberList.Add(4);
            numberList.Add(5);

            Dictionary<string,string> keyValuePairs = new Dictionary<string,string>(); //Dictionary
            keyValuePairs.Add("Erik", "Egnatosyan");
            keyValuePairs.Add("Georgi", "Pogosyan");

            Hashtable hashtable = new Hashtable(); //Hashtable
            hashtable.Add(1, "e");
            hashtable.Add(2, "r");
            hashtable.Add(3, "i");
            hashtable.Add(4, "k");

            Stack<string> stack = new Stack<string>(); //Stack
            stack.Push("Erik 1");
            stack.Push("Georgi 2");
            stack.Push("Suren 3");
            stack.Pop();

            Queue<string> queue = new Queue<string>(); //Queue
            queue.Enqueue("Erik 1");
            queue.Enqueue("Georgi 2");
            queue.Enqueue("Suren 3");
            queue.Dequeue();

            StringBuilder sb = new StringBuilder(); //Stringbuilder
            sb.Append("Erik 1\n");
            sb.Append("Georgi 2\n");
            sb.Append("Suren 3");

            foreach (int i in numberList) //List foreach
            {
                Console.Write(i);
            }

            Console.WriteLine();

            foreach (var number in keyValuePairs) //Dictionary foreach
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            foreach (var item in hashtable) //Hashtable foreach
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (var item in stack) //stack foreach
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach(var item in queue) //queue foreach
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            for (int i = 0; i < sb.Length; i++) //substring for
            {
                Console.Write(sb[i]);
            }
        }
    }
}