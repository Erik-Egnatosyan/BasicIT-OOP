namespace InterfaceExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankMenu bankMenu = new BankMenu();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1)Check Balance\n2)Deposit\n3)Withdraw\n4)Transfer");
                byte fourOp = Convert.ToByte(Console.ReadLine());
                switch (fourOp) 
                { 
                    case 1:
                        bankMenu.Balance();
                        break;
                    case 2:
                        bankMenu.Deposit(); 
                        break;
                    case 3:
                        bankMenu.Withdraw();
                        break;
                    case 4:
                        bankMenu.Transfer();
                        break;
                    default: 
                        Console.WriteLine("Wrong");
                        break;
                } 
            }
        }
    }
}