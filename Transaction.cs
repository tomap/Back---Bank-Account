
using System;
using System.Collections.Generic;
namespace csharp_cpp_java_bank_account
{
public class Transaction
{
    public decimal Amount { get; private set; }
    public TransactionType Type { get; private set; }
    public DateTime Date { get; private set; }

    public Transaction(decimal amount, TransactionType type)
    {
        Amount = amount;
        Type = type;
        Date = DateTime.Now;
    }
}
public enum TransactionType
{
    Deposit,
    Withdrawal
}

}

