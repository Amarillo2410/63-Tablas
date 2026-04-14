namespace ModeloTransporta.src.Modules.TransportCompany.Infrastructure.Entity;

public class TransportCompanyEntity
{
    public int id { get; set; }
    public string name { get; set; } = string.Empty;
    public string taxId { get; set; } = string.Empty;
    public string address { get; set; } = string.Empty;
    public string phone { get; set; } = string.Empty;
    public int cityId { get; set; }
}