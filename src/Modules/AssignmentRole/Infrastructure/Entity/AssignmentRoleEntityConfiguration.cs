using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.AssignmentRole.Infrastructure.Entity;

public sealed class AssignmentRoleEntityConfiguration : IEntityTypeConfiguration<AssignmentRoleEntity>
{
    public void Configure(EntityTypeBuilder<AssignmentRoleEntity> builder)
    {
        builder.ToTable("assignment_role");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.name)
            .HasColumnName("name")
            .HasColumnType("varchar(100)")
            .IsRequired();
    }
}