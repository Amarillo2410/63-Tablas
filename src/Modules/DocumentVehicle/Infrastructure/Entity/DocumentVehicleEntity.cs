namespace ModeloTransporta.src.Modules.DocumentVehicle.Infrastructure.Entity;

public class DocumentVehicleEntity
{
    public int id { get; set; }
    public string documentNumber { get; set; } = string.Empty;
    public DateTime expirationDate { get; set; }
    public string fileUrl { get; set; } = string.Empty;
    public int vehicleId { get; set; }
    public int typeDocumentId { get; set; }
}