namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32 };
            Console.WriteLine($"I found your number in {BinarySearch(arr, 55)} step!");
            Console.WriteLine(3/2);
        }
        public static int BinarySearch(int[] arr, int x)
        {
            int low = 0;
            int high = arr.Length - 1;
            int count = 0;
            while (low <= high)
            {
                int mid = low + ((high - low) / 2);
                if (arr[mid] == x)
                {
                    count++;
                    return count;
                }
                else if (arr[mid] < x)
                {
                    low = mid + 1;
                    count++;
                }
                else
                {
                    high = mid - 1;
                    count++;
                }
            }
            return -1;
        }
    }
}