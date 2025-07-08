namespace MockBankingAccount.Account;

public class UserDataBank
{
    public static Dictionary<string,AbstractUser> Users { get;  } = new();

    public static void StoreUser(AbstractUser user)
    {
        Users.Add(user.UserId,user);
    }
}