namespace ModeloTransporta.src.Modules.Bid.Infrastructure.Entity;

public class BidEntity
{
    public int id { get; set; }
    public decimal amount { get; set; }
    public DateTime estimatedDelivery { get; set; }
    public DateTime createdAt { get; set; }
    public int loadId { get; set; }
    public int driverId { get; set; }
    public int statusBidId { get; set; }
}