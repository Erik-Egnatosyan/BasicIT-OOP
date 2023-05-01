namespace ArrayCopy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] source = { 1, 2, 3 };
            int[] destination = new int[3];

            Array.Copy(source, destination, source.Length);
            source.CopyTo(destination, 0);
            foreach (int i in destination)
            {
                Console.WriteLine(i);
            }
        }
    }
}