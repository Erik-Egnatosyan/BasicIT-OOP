using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractChatGPT
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(decimal balance, string accountNumber) : base(balance, accountNumber)
        {
        }

        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        public override decimal CalculateInterest()
        {
            return Balance * 0.01m;
        }
    }
}
