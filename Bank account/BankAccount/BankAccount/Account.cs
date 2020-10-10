using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class Account : IDeposit
    {
        private readonly Owner owner;
        private decimal sum;
        private bool open;

        public Account (Owner owner)
        {
            this.owner = owner;
            this.sum = 0;
            this.open = true;
        }

        public void Closing()
        {
            open = false;
        }

        public virtual bool Withdraw(decimal sumWithdraw)
        {
            if (sum > sumWithdraw && open)
            {
                sum -= sumWithdraw;
                return true;
            }
            return false;
        }

        public virtual bool Deposit(decimal sumDeposit)
        {
            if (open)
            {
                sum += sumDeposit;
                return true;
            }
            return false;
        }

        public Owner Owner
        {
            get { return owner; }
        }

        public decimal Sum
        {
            get { return sum; }
            protected set { sum = value; }
        }

        public bool Open
        {
            get { return open; }
        }
    }
}
