namespace ModeloTransporta.src.Modules.Plan.Infrastructure.Entity;

public class PlanEntity
{
    public int id { get; set; }
    public string name { get; set; } = string.Empty;
    public decimal price { get; set; }
    public int durationDays { get; set; }
}