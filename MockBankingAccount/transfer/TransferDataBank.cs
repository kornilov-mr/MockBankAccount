namespace MockBankingAccount.transfer;

public class TransferDataBank
{
    public static Dictionary<string,TransferInfo> Transfers { get;  } = new();

    public static void StoreTransferInfo(TransferInfo info)
    {
        Transfers.Add(info.TransferId,info);
    }

    public static void RemoveTransferInfo(TransferInfo info)
    {
        Transfers.Remove(info.TransferId);
    }

    public static TransferInfo? GetTransferInfo(string transferId)
    {
        return Transfers.GetValueOrDefault(transferId);
    }
}