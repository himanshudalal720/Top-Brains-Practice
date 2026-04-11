public class LoanAccount : BankAccount
{
    private const decimal InterestRate = 0.10m;

    public override void Deposit(decimal amount)
    {
        throw new InvalidTransactionException("Cannot deposit into loan account.");
    }

    public override decimal CalculateInterest()
    {
        return Balance * InterestRate;
    }
}
