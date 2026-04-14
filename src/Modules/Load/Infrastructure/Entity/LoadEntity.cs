namespace ModeloTransporta.src.Modules.Load.Infrastructure.Entity;

public class LoadEntity
{
    public int id { get; set; }
    public string description { get; set; } = string.Empty;
    public string originAddress { get; set; } = string.Empty;
    public string destinationAddress { get; set; } = string.Empty;
    public decimal weight { get; set; }
    public decimal volume { get; set; }
    public int typeLoadId { get; set; }
    public int customerId { get; set; }
}