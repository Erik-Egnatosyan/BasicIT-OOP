namespace LambdaExamples
{
    internal class Program
    {
        public delegate bool CompareDelegate(int a, int b);
        public delegate string PlusToString(string a, int b);
        static void Main(string[] args)
        {
            CompareDelegate cD = (x, y) => x == y;
            bool result1 = cD(7,7);
            PlusToString plus = (x, y) => x + y.ToString();
            string result2 = plus("Erik ", 156);
            Console.WriteLine(result2);
        }
    } 
}