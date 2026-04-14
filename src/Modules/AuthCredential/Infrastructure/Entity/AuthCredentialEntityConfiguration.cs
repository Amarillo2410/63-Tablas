using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.AuthCredential.Infrastructure.Entity;

public sealed class AuthCredentialEntityConfiguration : IEntityTypeConfiguration<AuthCredentialEntity>
{
    public void Configure(EntityTypeBuilder<AuthCredentialEntity> builder)
    {
        builder.ToTable("auth_credentials");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.username)
            .HasColumnName("username")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(x => x.passwordHash)
            .HasColumnName("password_hash")
            .HasColumnType("varchar(255)")
            .IsRequired();

        builder.Property(x => x.lastLogin)
            .HasColumnName("last_login")
            .HasColumnType("datetime");

        builder.Property(x => x.isActive)
            .HasColumnName("is_active")
            .HasColumnType("tinyint(1)")
            .IsRequired();

        builder.Property(x => x.personId)
            .HasColumnName("person_id")
            .IsRequired();
    }
}