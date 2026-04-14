namespace ModeloTransporta.src.Modules.TypeVehicle.Infrastructure.Entity;

public class TypeVehicleEntity
{
    public int id { get; set; }
    public string name { get; set; } = string.Empty;
    public string description { get; set; } = string.Empty;
    public decimal capacityKg { get; set; }
    public decimal capacityM3 { get; set; }
}