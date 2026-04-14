namespace ModeloTransporta.src.Modules.Customer.Infrastructure.Entity;

public class CustomerEntity
{
    public int id { get; set; }
    public bool isFrequent { get; set; }
    public string companyName { get; set; } = string.Empty;
    public int personId { get; set; }
}