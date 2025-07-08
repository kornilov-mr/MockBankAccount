using MockBankingAccount.Account;
using MockBankingAccount.basicOperation;
using NUnit.Framework;

namespace MockBankingAccount.tests;

[TestFixture]
public class DepositTests
{
    [Test]
    public void DepositMoneyTest1()
    {
        BasicUser user = new BasicUser("sweed", "123");
        AbstractAccount account = new AbstractAccount(100,"Sparkasse");
        DepositController.DepositMoney(account.AccountId,100);
        Assert.That(account.Amount, Is.EqualTo(200));
    }
}