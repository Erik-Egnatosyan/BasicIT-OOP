using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractChatGPT
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; }

        public SavingsAccount(decimal balance, string accountNumber, decimal interestRate) : base(balance, accountNumber)
        {
            InterestRate = interestRate;
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
            return Balance * InterestRate;
        }
    }
}
