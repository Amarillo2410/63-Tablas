namespace ModeloTransporta.src.Modules.PriceHistory.Infrastructure.Entity;

public class PriceHistoryEntity
{
    public int id { get; set; }
    public decimal oldPrice { get; set; }
    public decimal newPrice { get; set; }
    public DateTime changeDate { get; set; }
}