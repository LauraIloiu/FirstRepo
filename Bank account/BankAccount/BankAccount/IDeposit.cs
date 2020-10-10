using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    interface IDeposit
    {
        bool Deposit(decimal sumDeposit);
    }
}
