namespace ModeloTransporta.src.Modules.Person.Infrastructure.Entity;

public class PersonEntity
{
    public int id { get; set; }
    public string firstName { get; set; } = string.Empty;
    public string lastName { get; set; } = string.Empty;
    public string email { get; set; } = string.Empty;
    public string phone { get; set; } = string.Empty;
    public string address { get; set; } = string.Empty;
    public int cityId { get; set; }
    public int statusId { get; set; }
}