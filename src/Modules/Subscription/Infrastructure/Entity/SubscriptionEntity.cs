namespace ModeloTransporta.src.Modules.Subscription.Infrastructure.Entity;

public class SubscriptionEntity
{
    public int id { get; set; }
    public DateTime startDate { get; set; }
    public DateTime endDate { get; set; }
    public int planId { get; set; }
    public int subscriberId { get; set; }
    public int statusId { get; set; }
}