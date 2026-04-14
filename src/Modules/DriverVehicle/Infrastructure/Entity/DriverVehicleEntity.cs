namespace ModeloTransporta.src.Modules.DriverVehicle.Infrastructure.Entity;

public class DriverVehicleEntity
{
    public int id { get; set; }
    public bool isActive { get; set; }
    public DateTime assignedAt { get; set; }
    public int vehicleId { get; set; }
    public int driverId { get; set; }
}