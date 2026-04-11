public class SavingsAccount : BankAccount
{
    private const decimal MinimumBalance = 1000;
    private const decimal InterestRate = 0.04m;

    public override void Withdraw(decimal amount)
    {
        if (Balance - amount < MinimumBalance)
            throw new MinimumBalanceException("Minimum balance violation.");

        base.Withdraw(amount);
    }

    public override decimal CalculateInterest()
    {
        return Balance * InterestRate;
    }
}
