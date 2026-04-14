namespace ModeloTransporta.src.Modules.PersonRole.Infrastructure.Entity;

public class PersonRoleEntity
{
    public int id { get; set; }
    public DateTime assignedAt { get; set; }
    public int personId { get; set; }
    public int roleId { get; set; }
}