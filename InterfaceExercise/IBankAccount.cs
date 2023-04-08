using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IBankAccount
    {
        void Balance();
        void Deposit();
        void Withdraw();
        void Transfer();
    }
}
