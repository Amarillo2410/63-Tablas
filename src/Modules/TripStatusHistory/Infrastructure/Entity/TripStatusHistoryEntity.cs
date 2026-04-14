namespace ModeloTransporta.src.Modules.TripStatusHistory.Infrastructure.Entity;

public class TripStatusHistoryEntity
{
    public int id { get; set; }
    public string statusName { get; set; } = string.Empty;
    public string locationCoords { get; set; } = string.Empty;
    public DateTime createdAt { get; set; }
    public int tripId { get; set; }
}