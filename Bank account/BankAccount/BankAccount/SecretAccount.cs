using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class SecretAccount : Account
    {
        public SecretAccount(Owner owner) : base(owner) { }

        public override bool Withdraw(decimal sumWithdraw)
        {
            if (Sum > sumWithdraw && Open && DateTime.Now.Month != 10)
            {
                Sum -= (sumWithdraw + (sumWithdraw * (decimal)0.02));
                return true;
            }
            return false;
        }
    }
}
