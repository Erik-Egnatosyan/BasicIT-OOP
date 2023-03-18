namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Class1.MDel mDeleg = new Class1.MDel(class1.Method1);   
            mDeleg += new Class1.MDel(class1.Method2);
            mDeleg += new Class1.MDel(class1.Method3);
            int Balance = mDeleg(10);
            int Add = mDeleg(10);
            int Out = mDeleg(10);
            Console.WriteLine($"{Balance} {Add} {Out}");
        }
    }
}