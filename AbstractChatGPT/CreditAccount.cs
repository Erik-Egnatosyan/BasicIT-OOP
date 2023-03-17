using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractChatGPT
{
    internal class CreditAccount : BankAccount
    {
        public override decimal CalculateInterest()
        {
            return 1;
        }
    }
}
