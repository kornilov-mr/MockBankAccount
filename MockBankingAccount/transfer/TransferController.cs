using MockBankingAccount.Account;

namespace MockBankingAccount.transfer;

public class TransferController
{
    public static bool ValidateAmount(TransferInfo info)
    {
        var receiverAccount = AccountDataBank.GetAccount(info.ReceiverAccountId);
        var senderAccount = AccountDataBank.GetAccount(info.SenderAccountId);

        return receiverAccount != null && senderAccount != null && senderAccount.Amount > info.Amount;
    }

    public static bool ValidateSameBank(TransferInfo info)
    {
        var receiverAccount = AccountDataBank.GetAccount(info.ReceiverAccountId);
        var senderAccount = AccountDataBank.GetAccount(info.SenderAccountId);

        return receiverAccount != null && senderAccount != null && senderAccount.BankName == receiverAccount.BankName;
    }
    
    public static void TryToTransfer(TransferInfo info)
    {
        if (!ValidateAmount(info)) throw new TransferException("Failed to transfer money, too few money on the sender account");
        if (!ValidateSameBank(info)) throw new TransferException("Failed to transfer money, different bank transfer");
        var receiverAccount = AccountDataBank.GetAccount(info.ReceiverAccountId);
        var senderAccount = AccountDataBank.GetAccount(info.SenderAccountId);
        receiverAccount!.DepositAmount(info.Amount);
        senderAccount!.WithdrawalAmount(info.Amount);
        TransferDataBank.StoreTransferInfo(info);
    }
    
}