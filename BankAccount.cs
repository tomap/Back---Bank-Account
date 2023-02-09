using System;
using System.Collections.Generic;
namespace csharp_cpp_java_bank_account
{
public class BankAccount
    {
    
    public int Id { get; set; }
    private List<Transaction> transactions;

    public decimal Balance { get; private set; }

    public BankAccount()
    {
        transactions = new List<Transaction>();
    }

    public void Deposit(decimal amount)
    {
        transactions.Add(new Transaction(amount, TransactionType.Deposit));
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        transactions.Add(new Transaction(amount, TransactionType.Withdrawal));
        Balance -= amount;
    }

    public decimal GetBalance()
    {
        return Balance;
    }

    public List<Transaction> GetTransactionHistory()
    {
        return transactions;
    }

}
}