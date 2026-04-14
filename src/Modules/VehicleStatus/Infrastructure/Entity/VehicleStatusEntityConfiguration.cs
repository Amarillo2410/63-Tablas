using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.VehicleStatus.Infrastructure.Entity;

public sealed class VehicleStatusEntityConfiguration : IEntityTypeConfiguration<VehicleStatusEntity>
{
    public void Configure(EntityTypeBuilder<VehicleStatusEntity> builder)
    {
        builder.ToTable("vehicles_status");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.name)
            .HasColumnName("name")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(x => x.description)
            .HasColumnName("description")
            .HasColumnType("varchar(255)")
            .IsRequired();
    }
}