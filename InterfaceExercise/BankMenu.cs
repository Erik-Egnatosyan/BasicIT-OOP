using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class BankMenu : IBankAccount
    {
        private decimal Person1Balance = 5000;
        private decimal Person2Balance = 2000;
        public void Balance()
        {
            Console.WriteLine($"1)First acc -> {Person1Balance}\n2)Second acc -> {Person2Balance}");
        }

        public void Deposit()
        {
            Console.WriteLine($"Which bank account do you want to use to add money?\n1)First acc -> {Person1Balance}\n2)Second acc -> {Person2Balance}");
            byte chooseAcc = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("How much do you want to add?");
            if (chooseAcc == 1)
            {
                decimal moneyWithdraw = Convert.ToDecimal(Console.ReadLine());
                Person1Balance += moneyWithdraw;
            }
            else if (chooseAcc == 2)
            {
                decimal moneyWithdraw = Convert.ToDecimal(Console.ReadLine());
                Person2Balance += moneyWithdraw;
            }
            Console.WriteLine($"1)First acc -> {Person1Balance}\n2)Second acc -> {Person2Balance}");
        }

        public void Transfer()
        {
            Console.WriteLine($"Which bank account do you want to transfer?\n1)First acc -> {Person1Balance}\n2)Second acc -> {Person2Balance}");
            byte choose = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("How much do you want to transfer?");
            if (choose == 1)
            {
                decimal moneyTransfer = Convert.ToDecimal(Console.ReadLine());
                Person1Balance -= moneyTransfer;
                Person2Balance += moneyTransfer;
            }
            else if(choose == 2)
            {
                decimal moneyTransfer = Convert.ToDecimal(Console.ReadLine());
                Person1Balance += moneyTransfer;
                Person2Balance -= moneyTransfer;
            }
            Console.WriteLine($"1)First acc -> {Person1Balance}\n2)Second acc -> {Person2Balance}");
        }

        public void Withdraw()
        {
            Console.WriteLine($"Which bank account do you want to use to withdraw?\n1)First acc -> {Person1Balance}\n2)Second acc -> {Person2Balance}");
            byte chooseAcc = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("How much do you want to withdraw?");
            if (chooseAcc == 1)
            {
                decimal moneyWithdraw = Convert.ToDecimal(Console.ReadLine());
                Person1Balance -= moneyWithdraw;
            }
            else if (chooseAcc == 2)
            {
                decimal moneyWithdraw = Convert.ToDecimal(Console.ReadLine());
                Person2Balance -= moneyWithdraw;
            }
            Console.WriteLine($"1)First acc -> {Person1Balance}\n2)Second acc -> {Person2Balance}");
        }
    }
}
