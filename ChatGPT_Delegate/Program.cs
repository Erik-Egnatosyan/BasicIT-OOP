namespace ChatGPT_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            double result = calculator.Calculate(2, 3, calculator.Plus);
            Console.WriteLine(result); 
        }
    }
}