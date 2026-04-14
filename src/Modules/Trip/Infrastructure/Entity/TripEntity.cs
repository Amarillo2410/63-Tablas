namespace ModeloTransporta.src.Modules.Trip.Infrastructure.Entity;

public class TripEntity
{
    public int id { get; set; }
    public DateTime startDate { get; set; }
    public DateTime endDate { get; set; }
    public string manifestNumber { get; set; } = string.Empty;
    public decimal totalPrice { get; set; }
    public int loadId { get; set; }
    public int vehicleId { get; set; }
    public int driverId { get; set; }
}