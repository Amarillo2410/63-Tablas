using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.TypeVehicle.Infrastructure.Entity;

public sealed class TypeVehicleEntityConfiguration : IEntityTypeConfiguration<TypeVehicleEntity>
{
    public void Configure(EntityTypeBuilder<TypeVehicleEntity> builder)
    {
        builder.ToTable("type_vehicles");

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

        builder.Property(x => x.capacityKg)
            .HasColumnName("capacity_kg")
            .HasColumnType("decimal(10,2)")
            .IsRequired();

        builder.Property(x => x.capacityM3)
            .HasColumnName("capacity_m3")
            .HasColumnType("decimal(10,2)")
            .IsRequired();
    }
}