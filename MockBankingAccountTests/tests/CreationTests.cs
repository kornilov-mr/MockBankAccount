using MockBankingAccount.Account;
using MockBankingAccount.transfer;
using NUnit.Framework;

namespace MockBankingAccount.tests;

[TestFixture]
public class CreationTests
{

    [Test]
    public void CreateAccount()
    {
        AbstractAccount account= new AbstractAccount(100,"Sparkasse");
        Assert.That(AccountDataBank.Accounts.ContainsKey(account.AccountId),Is.True);
    }
    [Test]
    public void CreateUser()
    {
        BasicUser account= new BasicUser("sweed","123");
        Assert.That(UserDataBank.Users.ContainsKey(account.UserId),Is.True);
    }
}