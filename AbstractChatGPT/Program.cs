namespace AbstractChatGPT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // создаем экземпляры объектов CheckingAccount и SavingsAccount
            var checkingAccount = new CheckingAccount(5000, "123456789");
            var savingsAccount = new SavingsAccount(10000, "987654321", 0.02m);

            // выводим текущий баланс для каждого счета
            Console.WriteLine($"Checking Account Balance: {checkingAccount.Balance}");
            Console.WriteLine($"Savings Account Balance: {savingsAccount.Balance}");

            // вносим депозиты на каждый счет
            checkingAccount.Deposit(1000);
            savingsAccount.Deposit(2000);

            // выводим новый баланс для каждого счета
            Console.WriteLine($"Checking Account Balance after deposit: {checkingAccount.Balance}");
            Console.WriteLine($"Savings Account Balance after deposit: {savingsAccount.Balance}");

            // снимаем деньги с каждого счета
            checkingAccount.Withdraw(500);
            savingsAccount.Withdraw(1000);

            // выводим новый баланс для каждого счета
            Console.WriteLine($"Checking Account Balance after withdrawal: {checkingAccount.Balance}");
            Console.WriteLine($"Savings Account Balance after withdrawal: {savingsAccount.Balance}");

            // расчитываем и выводим проценты для каждого счета
            decimal checkingInterest = checkingAccount.CalculateInterest();
            decimal savingsInterest = savingsAccount.CalculateInterest();
            Console.WriteLine($"Checking Account Interest: {checkingInterest}");
            Console.WriteLine($"Savings Account Interest: {savingsInterest}");

            Console.ReadKey();
        }
    }
}