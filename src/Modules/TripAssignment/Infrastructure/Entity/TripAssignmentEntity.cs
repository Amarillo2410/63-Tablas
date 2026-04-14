namespace ModeloTransporta.src.Modules.TripAssignment.Infrastructure.Entity;

public class TripAssignmentEntity
{
    public int id { get; set; }
    public DateTime assignedAt { get; set; }
    public bool isConfirmed { get; set; }
    public int tripId { get; set; }
    public int driverId { get; set; }
}