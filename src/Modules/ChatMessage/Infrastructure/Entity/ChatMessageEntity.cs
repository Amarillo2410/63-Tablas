namespace ModeloTransporta.src.Modules.ChatMessage.Infrastructure.Entity;

public class ChatMessageEntity
{
    public int id { get; set; }
    public string messageText { get; set; } = string.Empty;
    public DateTime sentAt { get; set; }
    public int roomId { get; set; }
    public int senderId { get; set; }
}