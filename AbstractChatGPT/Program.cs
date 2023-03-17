namespace AbstractChatGPT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount account = new CheckingAccount();
            CreditAccount creditAccount = new CreditAccount();
            SavingAccount saveAccount = new SavingAccount();
            Console.WriteLine("Hello! Welcome to our Bank!");
            while (true)
            {
                Console.WriteLine("What do you want to do?\n1)Check balance\n2)Saving money\n3)Credit money");
                int numberInput = Convert.ToInt32(Console.ReadLine());
                switch (numberInput)
                {
                    case 1:
                        Console.WriteLine($"You have {account.CalculateInterest()}$");
                        break;
                    case 2:
                        Console.WriteLine($"You save {saveAccount.CalculateInterest()}$");
                        break;
                    case 3:
                        Console.WriteLine($"You get {creditAccount.CalculateInterest()}$ credit");
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
            }
        }
    }
}