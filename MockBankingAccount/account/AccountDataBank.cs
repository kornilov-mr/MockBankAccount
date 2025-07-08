namespace MockBankingAccount.Account;

public class AccountDataBank
{
    public static Dictionary<string, AbstractAccount> Accounts { get;  } = new();

    public static void StoreAccount(AbstractAccount account)
    {
        Accounts.Add(account.AccountId,account);
    }

    public static void RemoveAccount(AbstractAccount account)
    {
        Accounts.Remove(account.AccountId);
    }

    public static AbstractAccount? GetAccount(string id)
    {
        return Accounts.GetValueOrDefault(id);
    }

  
    
}