namespace ModeloTransporta.src.Modules.DocumentDriver.Infrastructure.Entity;

public class DocumentDriverEntity
{
    public int id { get; set; }
    public string documentNumber { get; set; } = string.Empty;
    public DateTime expiryDate { get; set; }
    public int driverId { get; set; }
    public int typeDocumentId { get; set; }
    public int statusId { get; set; }
}