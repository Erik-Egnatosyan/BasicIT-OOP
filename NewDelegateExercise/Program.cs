namespace NewDelegateExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            strProc();
            numberProc();
        }
        public static void strProc()
        {
            StringProcessor processor = new StringProcessor();
            string str = "Hello World!";
            str = processor.ProcessString(str, processor.LowerCaseStr);
            Console.WriteLine(str);
        }
        public static void numberProc()
        {
            NumberProcessor processor = new NumberProcessor();
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            ints = processor.MyInts(ints, processor.EvenNumber);
        }
    }
}