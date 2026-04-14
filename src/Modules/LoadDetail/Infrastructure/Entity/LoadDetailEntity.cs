namespace ModeloTransporta.src.Modules.LoadDetail.Infrastructure.Entity;

public class LoadDetailEntity
{
    public int id { get; set; }
    public int quantity { get; set; }
    public string unitMeasure { get; set; } = string.Empty;
    public string specialInstructions { get; set; } = string.Empty;
    public int loadId { get; set; }
}