namespace SortingSomeValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ListSort();
            //ArraySort();
            QueueSort();
        }
        public static void ListSort()
        {
            List<int> values = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                values.Add(rnd.Next(1, 10000));
            }
            values.Sort();
            for (int i = 0; i < 20; i++)
            {
                Console.Write($"{values[i]} ");
            }
        }
        public static void ArraySort()
        {
            int[] arr = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 10);
            }
            Array.Sort(arr);
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
        public static void QueueSort()
        {
            Queue<int> values = new Queue<int>();
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                values.Enqueue(rnd.Next(1, 10));
            }

            int[] array = values.ToArray();
            Array.Sort(array);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}