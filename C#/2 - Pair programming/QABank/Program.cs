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
public class CurrentAccount : BankAccount {
    public decimal OverdraftLimit { get; set; }

    public CurrentAccount(string customerName, decimal overdraftLimit = 0, int accountNumber = 0, decimal balance = 0)
        : base(customerName, accountNumber, balance) {
        OverdraftLimit = overdraftLimit;
    }

    public new void Withdraw(decimal amount) {
        if (Balance + OverdraftLimit >= amount) {
            Balance -= amount;
        } else {
            throw new Exception("Insufficient funds.");
        }
    }
}

public class SavingsAccount : BankAccount {
    public decimal InterestRate { get; set; }

    public SavingsAccount(string customerName, decimal interestRate, int accountNumber = 0, decimal balance = 0)
        : base(customerName, accountNumber, balance) {
        InterestRate = interestRate;
    }

    public void AddInterest() {
        decimal interest = Balance * InterestRate / 100;
        Balance += interest;
    }
}
