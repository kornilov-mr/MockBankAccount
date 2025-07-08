namespace MockBankingAccount.transfer;

public class TransferException(string reason) : Exception(reason)
{
    
}