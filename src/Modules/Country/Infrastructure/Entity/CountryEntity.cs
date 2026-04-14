namespace ModeloTransporta.src.Modules.Country.Infrastructure.Entity;

public class CountryEntity
{
    public int id { get; set; }
    public string name { get; set; } = string.Empty;
    public string isoCode { get; set; } = string.Empty;
    public string phoneCode { get; set; } = string.Empty;
}