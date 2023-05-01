namespace ArrayCopy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] source = { 1, 2, 3 };
            int[] destination = new int[3];

            Array.Copy(source, destination, source.Length); //Метод Copy копирует элементы массива в новый массив с заданным размером. 
            source.CopyTo(destination, 0); //Метод CopyTo копирует элементы массива в уже существующий массив, начиная с определенного индекса в этом массиве.
            foreach (int i in destination)
            {
                Console.WriteLine(i);
            }
            Convert.ToInt32(Co);
        }
    }
}