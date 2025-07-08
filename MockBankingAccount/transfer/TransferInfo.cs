namespace MockBankingAccount.transfer;

public class TransferInfo
{
    public TransferInfo(string receiverAccountId, string senderAccountId, double amount)
    {
        ReceiverAccountId = receiverAccountId;
        SenderAccountId = senderAccountId;
        Amount = amount;
    }

    public string ReceiverAccountId { get; }
    public string SenderAccountId { get; }
    public double Amount { get; }
    public string TransferId = Guid.NewGuid().ToString();
    
}