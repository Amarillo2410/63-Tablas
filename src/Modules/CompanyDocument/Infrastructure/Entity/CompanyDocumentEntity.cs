namespace ModeloTransporta.src.Modules.CompanyDocument.Infrastructure.Entity;

public class CompanyDocumentEntity
{
    public int id { get; set; }
    public string fileUrl { get; set; } = string.Empty;
    public DateTime expiryDate { get; set; }
    public int companyId { get; set; }
    public int typeDocumentId { get; set; }
}