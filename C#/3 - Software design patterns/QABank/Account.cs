using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QABank
{
    public abstract class Account
    {
        protected int balance;
        protected string name;

        public abstract bool Withdraw(int amount);

        public int Balance
        {
            get
            {
                return this.balance;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public bool Deposit(int amount)
        {
            this.balance += amount;
            return true;
        }

        public override string ToString()
        {
            return $"BALANCE={Balance}, NAME={Name}";
        }
    }
}
