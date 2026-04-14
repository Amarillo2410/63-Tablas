namespace ModeloTransporta.src.Modules.Driver.Infrastructure.Entity;

public class DriverEntity
{
    public int id { get; set; }
    public string licenseNumber { get; set; } = string.Empty;
    public string licenseCategory { get; set; } = string.Empty;
    public int experienceYears { get; set; }
    public int personId { get; set; }
}