using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QABank
{
    public static class AccountFactory
    {
        public static Account GetAccount(string type, int balance, string name, int overdraftLimit)
        {
            if ("Current".Equals(type, StringComparison.InvariantCultureIgnoreCase))
            {
                return new CurrentAccount(balance, name, overdraftLimit);
            }
            else if ("Savings".Equals(type, StringComparison.InvariantCultureIgnoreCase))
            {
                return new SavingsAccount(balance, name);
            }

            return null;
        }
    }
}
