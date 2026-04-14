namespace ModeloTransporta.src.Modules.LoadStatusHistory.Infrastructure.Entity;

public class LoadStatusHistoryEntity
{
    public int id { get; set; }
    public string statusName { get; set; } = string.Empty;
    public DateTime changedAt { get; set; }
    public string notes { get; set; } = string.Empty;
    public int loadId { get; set; }
    public int changedById { get; set; }
}