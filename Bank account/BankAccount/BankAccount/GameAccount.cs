using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class GameAccount : IDeposit
    {
        private decimal sum;

        public decimal Sum
        {
            get { return sum; }
            set { sum = value; }
        }
        public bool Deposit(decimal sumDeposit)
        {
            Sum += (sumDeposit + (sumDeposit * (decimal)0.01));
            return true;

        }
    }
}
