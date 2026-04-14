namespace ModeloTransporta.src.Modules.AuthSession.Infrastructure.Entity;

public class AuthSessionEntity
{
    public int id { get; set; }
    public string token { get; set; } = string.Empty;
    public string ipAddress { get; set; } = string.Empty;
    public string deviceInfo { get; set; } = string.Empty;
    public DateTime createdAt { get; set; }
    public DateTime expiresAt { get; set; }
    public int authId { get; set; }
}