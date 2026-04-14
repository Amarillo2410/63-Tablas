namespace ModeloTransporta.src.Modules.Rating.Infrastructure.Entity;

public class RatingEntity
{
    public int id { get; set; }
    public int score { get; set; }
    public string comment { get; set; } = string.Empty;
    public DateTime createdAt { get; set; }
    public int tripId { get; set; }
    public int evaluatorId { get; set; }
    public int evaluatedId { get; set; }
}