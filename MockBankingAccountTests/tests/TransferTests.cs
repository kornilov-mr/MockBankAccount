using MockBankingAccount.Account;
using MockBankingAccount.basicOperation;
using MockBankingAccount.transfer;
using NUnit.Framework;

namespace MockBankingAccount.tests;

[TestFixture]
public class TransferTests
{

    [Test]
    public void TransferTest1()
    {
        AbstractAccount account1 = new AbstractAccount(100,"Sparkasse");
        AbstractAccount account2 = new AbstractAccount(100,"Revolut");
        
        TransferInfo info = new TransferInfo(account1.AccountId,account2.AccountId,99);
        var ex = Assert.Catch<Exception>(() => TransferController.TryToTransfer(info));
        
        Assert.That(ex!, Is.TypeOf<TransferException>());
        Assert.That(ex!.Message, Is.EqualTo("Failed to transfer money, different bank transfer"));
    }
    [Test]
    public void TransferTest2()
    {
        AbstractAccount account1 = new AbstractAccount(100,"Sparkasse");
        AbstractAccount account2 = new AbstractAccount(100,"Sparkasse");
        
        TransferInfo info = new TransferInfo(account1.AccountId,account2.AccountId,99);
        TransferController.TryToTransfer(info);
        Assert.That(account1.Amount, Is.EqualTo(199));
        Assert.That(account2.Amount, Is.EqualTo(1));
        Assert.That(TransferDataBank.Transfers.ContainsKey(info.TransferId),Is.True);
    }
}