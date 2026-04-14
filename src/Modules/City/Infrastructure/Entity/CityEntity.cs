namespace ModeloTransporta.src.Modules.City.Infrastructure.Entity;

public class CityEntity
{
    public int id { get; set; }
    public string name { get; set; } = string.Empty;
    public string zipCode { get; set; } = string.Empty;
    public int stateId { get; set; }
}