using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.AuthSession.Infrastructure.Entity;

public sealed class AuthSessionEntityConfiguration : IEntityTypeConfiguration<AuthSessionEntity>
{
    public void Configure(EntityTypeBuilder<AuthSessionEntity> builder)
    {
        builder.ToTable("auth_sessions");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.token)
            .HasColumnName("token")
            .HasColumnType("varchar(500)")
            .IsRequired();

        builder.Property(x => x.ipAddress)
            .HasColumnName("ip_address")
            .HasColumnType("varchar(50)");

        builder.Property(x => x.deviceInfo)
            .HasColumnName("device_info")
            .HasColumnType("varchar(255)");

        builder.Property(x => x.createdAt)
            .HasColumnName("created_at")
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(x => x.expiresAt)
            .HasColumnName("expires_at")
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(x => x.authId)
            .HasColumnName("auth_id")
            .IsRequired();
    }
}