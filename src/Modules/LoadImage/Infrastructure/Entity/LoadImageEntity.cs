namespace ModeloTransporta.src.Modules.LoadImage.Infrastructure.Entity;

public class LoadImageEntity
{
    public int id { get; set; }
    public string imageUrl { get; set; } = string.Empty;
    public string description { get; set; } = string.Empty;
    public DateTime createdAt { get; set; }
    public int loadId { get; set; }
}