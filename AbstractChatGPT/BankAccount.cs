using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractChatGPT
{
    internal abstract class BankAccount
    {
        public decimal Balance { get; set; } = 5000;
        public decimal Deposit { get; set; }
        public decimal Withdraw { get; set; }
        public abstract decimal CalculateInterest();
    }
}
