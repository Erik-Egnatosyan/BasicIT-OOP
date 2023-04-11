namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Enumerable.Range(1, 100).OrderBy(x => Guid.NewGuid()).ToArray();

            Console.WriteLine("Исходный массив:");
            foreach (int i in arr)
            {
                Console.Write($"{i}, ");
            }

            BubbleSort(arr);

            Console.WriteLine("\nОтсортированный массив:");
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }
        }
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // меняем местами элементы
                        (arr[j + 1], arr[j]) = (arr[j], arr[j + 1]); //Версия по короче
                        //int temp = arr[j];
                        //arr[j] = arr[j + 1];
                        //arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}