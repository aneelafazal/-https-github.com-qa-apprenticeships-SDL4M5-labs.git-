using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QABank
{
    class Program
    {
        static void Main(string[] args)
        {
            Account current = AccountFactory.GetAccount("current", 250, "My Current Account", 100);
            Account savings = AccountFactory.GetAccount("SAVINGS", 300, "My Savings Account", 0);

            // Initial values
            Console.WriteLine("Factory Current Account Details::" + current);
            Console.WriteLine("Factory Savings Account Details::" + savings);

            // Try to withdraw within Current account limit
            current.Withdraw(300);
            Console.WriteLine("Factory Current Account Details::" + current);

            // Try to go over Current overdraft limit
            current.Withdraw(300);
            Console.WriteLine("Factory Current Account Details::" + current);

            // Try to withdraw more than balance
            savings.Withdraw(350);
            Console.WriteLine("Factory Savings Account Details::" + savings);


            // Try to withdraw less than balance
            savings.Withdraw(200);
            Console.WriteLine("Factory Savings Account Details::" + savings);
        }
    }
}
