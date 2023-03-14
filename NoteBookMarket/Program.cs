namespace NoteBookMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EriksNotebook eriksNotebook = new EriksNotebook();
            INotebook ieriksNotebook = new EriksNotebook();
            eriksNotebook.Brand = "Georgi++";
            ieriksNotebook.Brand = "SpuerGeorgi++";
            eriksNotebook.FirstAcceleration();
            ieriksNotebook.SecondAcceleration(89);
            Console.WriteLine(eriksNotebook.Brand);
            Console.WriteLine(ieriksNotebook.Brand);
        }
    }
}