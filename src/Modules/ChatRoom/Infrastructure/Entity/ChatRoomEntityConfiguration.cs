using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.ChatRoom.Infrastructure.Entity;

public sealed class ChatRoomEntityConfiguration : IEntityTypeConfiguration<ChatRoomEntity>
{
    public void Configure(EntityTypeBuilder<ChatRoomEntity> builder)
    {
        builder.ToTable("chat_rooms");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.createdAt)
            .HasColumnName("created_at")
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(x => x.tripId)
            .HasColumnName("trip_id")
            .IsRequired();
    }
}