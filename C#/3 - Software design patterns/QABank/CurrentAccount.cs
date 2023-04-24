using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QABank
{
    public class CurrentAccount : Account
    {
        private int overdraftLimit;

        public CurrentAccount(int balance, string name, int overdraftLimit)
        {
            this.balance = balance;
            this.name = name;
            this.overdraftLimit = overdraftLimit;
        }

        public int OverdraftLimit
        {
            get
            {
                return this.overdraftLimit;
            }
        }

        public override bool Withdraw(int amount)
        {
            if (amount < this.balance + this.overdraftLimit)
            {
                this.balance -= amount;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"BALANCE={Balance}, NAME={Name}, OVERDRAFT LIMIT={OverdraftLimit}";
        }
    }
}
