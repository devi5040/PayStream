namespace paystream.src.domain;

public class TransactionEntity
{
    public Guid TransactionId { get; set; }
    public Guid MerchantId { get; set; }
    public string AccountId { get; set; } = string.Empty;
    public CurrencyEnum Currency { get; set; } = CurrencyEnum.INR;
    public decimal Amount { get; set; }
    public TransactionStatusEnum Status { get; set; } = TransactionStatusEnum.Pending;
    public string BillingCountry { get; set; } = string.Empty;
    public DateTime OccurredAt { get; set; } = DateTime.Now;
}