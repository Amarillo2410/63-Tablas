namespace ModeloTransporta.src.Modules.DocumentCustomer.Infrastructure.Entity;

public class DocumentCustomerEntity
{
    public int id { get; set; }
    public string documentNumber { get; set; } = string.Empty;
    public int customerId { get; set; }
    public int typeDocumentId { get; set; }
    public int statusId { get; set; }
}