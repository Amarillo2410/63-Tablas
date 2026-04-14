namespace ModeloTransporta.src.Modules.Payment.Infrastructure.Entity;

public class PaymentEntity
{
    public int id { get; set; }
    public decimal amount { get; set; }
    public string transactionReference { get; set; } = string.Empty;
    public DateTime date { get; set; }
    public int providerId { get; set; }
    public int statusId { get; set; }
}