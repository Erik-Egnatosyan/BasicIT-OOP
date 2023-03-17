using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractChatGPT
{
    public abstract class BankAccount
    {
        public decimal Balance { get; protected set; }
        public string AccountNumber { get; }

        public BankAccount(decimal balance, string accountNumber)
        {
            Balance = balance;
            AccountNumber = accountNumber;
        }

        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);
        public abstract decimal CalculateInterest();
    }
}
