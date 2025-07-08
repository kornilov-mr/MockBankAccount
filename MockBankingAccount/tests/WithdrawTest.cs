using MockBankingAccount.Account;
using MockBankingAccount.basicOperation;
using NUnit.Framework;

namespace MockBankingAccount.tests;

[TestFixture]
public class WithdrawTest
{
    [Test]
    public void WithdrawMoneyTest()
    {
        AbstractAccount account = new AbstractAccount(101,"Sparkasse");
        WithdrawController.WithdrawMoney(account.AccountId,100);
        Assert.That(account.Amount, Is.EqualTo(1));
    }
    [Test]
    public void WithdrawMoneyTest2()
    {
        AbstractAccount account = new AbstractAccount(99,"Sparkasse");
        var ex = Assert.Catch(() => WithdrawController.WithdrawMoney(account.AccountId,100));
        Assert.That(ex!, Is.TypeOf<BasicOperationException>());
        Assert.That(ex!.Message, Is.EqualTo("Not enough money on the account"));
    }
}