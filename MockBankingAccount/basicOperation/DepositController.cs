using MockBankingAccount.Account;

namespace MockBankingAccount.basicOperation;

public class DepositController
{
    public static bool ValidateAccountExists(string accountId)
    {
        var account = AccountDataBank.GetAccount(accountId);
        return account != null;
    }

    public static void DepositMoney(string accountId, double amount)
    {
        if(!ValidateAccountExists(accountId)) throw new BasicOperationException("Account isn't found");
        var account = AccountDataBank.GetAccount(accountId);
        account!.DepositAmount(amount);
    }
}