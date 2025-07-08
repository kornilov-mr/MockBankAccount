namespace MockBankingAccount.Account;

public abstract class AbstractUser
{
    public AbstractUser(string name, string password) : this(name, password, new List<AbstractAccount>())
    {
        
    }
    public AbstractUser(string name, string password, List<AbstractAccount> accounts)
    {
        Name = name;
        Password = password;
        Accounts = accounts;
        UserDataBank.StoreUser(this);
    }
    public string UserId = Guid.NewGuid().ToString();
    private string Name { get; }
    private string Password { get; }
    private List<AbstractAccount> Accounts { get; } 
    
    void AddAccount(AbstractAccount account)
    {
        Accounts.Add(account);
    }
}
