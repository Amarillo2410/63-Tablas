namespace ModeloTransporta.src.Modules.PersonTransport.Infrastructure.Entity;

public class PersonTransportEntity
{
    public int id { get; set; }
    public string roleInTrip { get; set; } = string.Empty;
    public int tripId { get; set; }
    public int personId { get; set; }
}