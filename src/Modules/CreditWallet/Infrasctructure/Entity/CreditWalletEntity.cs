namespace ModeloTransporta.src.Modules.CreditWallet.Infrastructure.Entity;

public class CreditWalletEntity
{
    public int id { get; set; }
    public decimal balance { get; set; }
    public DateTime lastUpdate { get; set; }
    public int? personId { get; set; }
    public int? companyId { get; set; }
}