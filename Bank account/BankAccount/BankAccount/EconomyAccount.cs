using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class EconomyAccount : Account
    {
        public EconomyAccount(Owner owner) : base(owner) { }

        public override bool Withdraw(decimal sumWithdraw)
        {
            if (Sum > sumWithdraw && Open)
            {
                Sum -= (sumWithdraw + (sumWithdraw * (decimal)0.02));
                return true;
            }
            return false;
        }

        public override bool Deposit(decimal sumDeposit)
        {
            if (Open)
            {
                Sum += (sumDeposit + (sumDeposit * (decimal)0.01));
                return true;
            }
            return false;
        }
    }
}
