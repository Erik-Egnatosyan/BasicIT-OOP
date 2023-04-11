namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 548, 888, 804, 981, 772, 807, 66, 42 };
            SelectionSort(ints);
            foreach (int i in ints)
                Console.WriteLine(i);
        }
        public static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    (arr[i],arr[minIndex]) = (arr[minIndex],arr[i]);
                }
            }
        }
       //Step              Array                 Min Value                  Swap
       //0	    548 888 804 981 772 807 66 42	    42	        42 888 804 981 772 807 66 548
       //1	    42 888 804 981 772 807 66 548	    66	        42 66 804 981 772 807 888 548
       //2	    42 66 804 981 772 807 888 548	    548	        42 66 548 981 772 807 888 804
       //3	    42 66 548 981 772 807 888 804	    772	        42 66 548 772 981 807 888 804
       //4	    42 66 548 772 981 807 888 804	    807	        42 66 548 772 807 981 888 804
       //5	    42 66 548 772 807 981 888 804	    804	        42 66 548 772 807 804 888 981
       //6	    42 66 548 772 807 804 888 981	    888	        42 66 548 772 807 804 888 981
    }
}