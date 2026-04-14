namespace ModeloTransporta.src.Modules.TravelScale.Infrastructure.Entity;

public class TravelScaleEntity
{
    public int id { get; set; }
    public int sequence { get; set; }
    public DateTime arrivalEstimated { get; set; }
    public DateTime departureActual { get; set; }
    public int tripId { get; set; }
}