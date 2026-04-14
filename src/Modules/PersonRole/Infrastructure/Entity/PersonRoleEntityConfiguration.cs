using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.PersonRole.Infrastructure.Entity;

public sealed class PersonRoleEntityConfiguration : IEntityTypeConfiguration<PersonRoleEntity>
{
    public void Configure(EntityTypeBuilder<PersonRoleEntity> builder)
    {
        builder.ToTable("person_roles");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.assignedAt)
            .HasColumnName("assigned_at")
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(x => x.personId)
            .HasColumnName("person_id")
            .IsRequired();

        builder.Property(x => x.roleId)
            .HasColumnName("role_id")
            .IsRequired();
    }
}