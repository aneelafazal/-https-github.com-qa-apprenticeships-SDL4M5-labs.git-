using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QABank
{
    public class SavingsAccount : Account
    {
        public SavingsAccount(int balance, string name)
        {
            this.balance = balance;
            this.name = name;
        }

        public override bool Withdraw(int amount)
        {
            if (amount < this.balance)
            {
                this.balance -= amount;
                return true;
            }
            return false;
        }
    }
}
