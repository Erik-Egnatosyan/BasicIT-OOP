using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractChatGPT
{
    internal class SavingAccount : BankAccount
    {
        public decimal saveMoneyBank { get; set; } = 0;
        public override decimal CalculateInterest()
        {
            Console.WriteLine($"You save {saveMoneyBank}$. Do you want save more or cash out?\n1)Save\n2)Cash out");
            int numberCheck = Convert.ToInt32(Console.ReadLine());
            if (numberCheck == 1)
            {
                Console.WriteLine("How much?");
                decimal moneyAdd = Convert.ToInt32(Console.ReadLine());
                if (moneyAdd < Balance)
                {
                    Balance -= moneyAdd;
                    saveMoneyBank = moneyAdd;
                }
                else if (moneyAdd > Balance)
                {
                    Console.WriteLine($"You cant save {moneyAdd} money, because you don't have");
                }
            }
            return saveMoneyBank;
        }
    }
}
