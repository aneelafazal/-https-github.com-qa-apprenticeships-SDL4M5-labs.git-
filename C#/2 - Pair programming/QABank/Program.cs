using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Test
public class BankAccount {
    private static int NextAccountNumber = 100000;

    public string CustomerName { get; set; }
    public int AccountNumber { get; }
    public decimal Balance { get; private set; }

    public BankAccount(string customerName, int accountNumber = 0, decimal balance = 0) {
        if (accountNumber == 0) {
            AccountNumber = NextAccountNumber++;
        } else {
            AccountNumber = accountNumber;
        }
        CustomerName = customerName;
        Balance = balance;
    }

    public void Deposit(decimal amount) {
        Balance += amount;
    }

    public void Withdraw(decimal amount) {
        Balance -= amount;
    }
}

