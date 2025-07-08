using MockBankingAccount.Account;

namespace MockBankingAccount.basicOperation;

public class WithdrawController
{
    public static bool ValidateAmount(string accountId, double amount)
    {
        var account = AccountDataBank.GetAccount(accountId);
        return account!=null && account.Amount>=amount;
    }

    public static double WithdrawMoney(string accountId, double amount)
    {
        if(!ValidateAmount(accountId, amount)) throw new BasicOperationException("Not enough money on the account");
        var account = AccountDataBank.GetAccount(accountId);
        account!.WithdrawalAmount(amount);
        return amount;
    }
}