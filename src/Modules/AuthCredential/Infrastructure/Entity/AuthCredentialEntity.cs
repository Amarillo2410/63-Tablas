namespace ModeloTransporta.src.Modules.AuthCredential.Infrastructure.Entity;

public class AuthCredentialEntity
{
    public int id { get; set; }
    public string username { get; set; } = string.Empty;
    public string passwordHash { get; set; } = string.Empty;
    public DateTime lastLogin { get; set; }
    public bool isActive { get; set; }
    public int personId { get; set; }
}