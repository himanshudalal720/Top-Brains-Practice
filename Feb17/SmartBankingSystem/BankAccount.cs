using System;
using System.Collections.Generic;

public abstract class BankAccount
{
    public string AccountNumber { get; set; }
    public string CustomerName { get; set; }
    public decimal Balance { get; protected set; }

    public List<string> TransactionHistory { get; } = new List<string>();

    public virtual void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new InvalidTransactionException("Deposit amount must be positive.");

        Balance += amount;
        TransactionHistory.Add($"Deposited: {amount}");
    }

    public virtual void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new InvalidTransactionException("Invalid withdrawal amount.");

        if (amount > Balance)
            throw new InsufficientBalanceException("Insufficient balance.");

        Balance -= amount;
        TransactionHistory.Add($"Withdrawn: {amount}");
    }

    public abstract decimal CalculateInterest();

    public void Transfer(BankAccount targetAccount, decimal amount)
    {
        Withdraw(amount);
        targetAccount.Deposit(amount);
        TransactionHistory.Add($"Transferred {amount} to {targetAccount.AccountNumber}");
    }

    public override string ToString()
    {
        return $"{AccountNumber} - {CustomerName} - {Balance}";
    }
}
