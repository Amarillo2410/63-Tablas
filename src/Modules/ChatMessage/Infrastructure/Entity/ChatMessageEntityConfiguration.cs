using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.ChatMessage.Infrastructure.Entity;

public sealed class ChatMessageEntityConfiguration : IEntityTypeConfiguration<ChatMessageEntity>
{
    public void Configure(EntityTypeBuilder<ChatMessageEntity> builder)
    {
        builder.ToTable("chat_messages");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.messageText)
            .HasColumnName("message_text")
            .HasColumnType("varchar(1000)")
            .IsRequired();

        builder.Property(x => x.sentAt)
            .HasColumnName("sent_at")
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(x => x.roomId)
            .HasColumnName("room_id")
            .IsRequired();

        builder.Property(x => x.senderId)
            .HasColumnName("sender_id")
            .IsRequired();
    }
}