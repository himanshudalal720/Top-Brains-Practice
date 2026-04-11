public class CurrentAccount : BankAccount
{
    public decimal OverdraftLimit { get; set; } = 5000;

    public override void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new InvalidTransactionException("Invalid withdrawal amount.");

        if (Balance - amount < -OverdraftLimit)
            throw new InsufficientBalanceException("Overdraft limit exceeded.");

        Balance -= amount;
        TransactionHistory.Add($"Withdrawn: {amount}");
    }

    public override decimal CalculateInterest()
    {
        return 0; // No interest
    }
}
