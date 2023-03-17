using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractChatGPT
{
    internal class CheckingAccount : BankAccount
    {
        SavingAccount savingAccount = new SavingAccount();
        public override decimal CalculateInterest()
        {
            return Balance - savingAccount.saveMoneyBank;
        }
    }
}
