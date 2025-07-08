namespace MockBankingAccount.Account;

public class AbstractAccount
{
    public AbstractAccount(double amount, string bankName)
    {
        if(amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount));
        Amount = amount;
        BankName = bankName;
        AccountDataBank.StoreAccount(this);
    }
    public string AccountId = Guid.NewGuid().ToString();
    public string BankName { get;private set; }
    public double Amount {get; private set; }

    public void DepositAmount(double amount)
    {
        Amount += amount;
    }

    public void WithdrawalAmount(double amount)
    {
        Amount -= amount;
    }
    
    
}