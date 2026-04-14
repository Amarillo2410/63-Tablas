namespace ModeloTransporta.src.Modules.ReturnLoadSuggestion.Infrastructure.Entity;

public class ReturnLoadSuggestionEntity
{
    public int id { get; set; }
    public DateTime suggestedAt { get; set; }
    public decimal relevanceScore { get; set; }
    public int currentTripId { get; set; }
    public int suggestedLoadId { get; set; }
}