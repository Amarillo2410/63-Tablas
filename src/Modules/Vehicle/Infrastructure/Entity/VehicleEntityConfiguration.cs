using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.Vehicle.Infrastructure.Entity;

public sealed class VehicleEntityConfiguration : IEntityTypeConfiguration<VehicleEntity>
{
    public void Configure(EntityTypeBuilder<VehicleEntity> builder)
    {
        builder.ToTable("vehicles");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.plate)
            .HasColumnName("plate")
            .HasColumnType("varchar(20)")
            .IsRequired();

        builder.Property(x => x.model)
            .HasColumnName("model")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(x => x.color)
            .HasColumnName("color")
            .HasColumnType("varchar(50)")
            .IsRequired();

        builder.Property(x => x.brand)
            .HasColumnName("brand")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(x => x.chassisNumber)
            .HasColumnName("chassis_number")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(x => x.engineNumber)
            .HasColumnName("engine_number")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(x => x.year)
            .HasColumnName("year")
            .IsRequired();

        builder.Property(x => x.typeVehicleId)
            .HasColumnName("type_vehicle_id")
            .IsRequired();

        builder.Property(x => x.statusId)
            .HasColumnName("status_id")
            .IsRequired();
    }
}