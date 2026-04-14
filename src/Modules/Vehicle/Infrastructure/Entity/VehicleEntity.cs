namespace ModeloTransporta.src.Modules.Vehicle.Infrastructure.Entity;

public class VehicleEntity
{
    public int id { get; set; }
    public string plate { get; set; } = string.Empty;
    public string model { get; set; } = string.Empty;
    public string color { get; set; } = string.Empty;
    public string brand { get; set; } = string.Empty;
    public string chassisNumber { get; set; } = string.Empty;
    public string engineNumber { get; set; } = string.Empty;
    public int year { get; set; }
    public int typeVehicleId { get; set; }
    public int statusId { get; set; }
}