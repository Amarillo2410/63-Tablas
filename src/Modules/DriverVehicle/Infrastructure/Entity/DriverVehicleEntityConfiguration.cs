using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.DriverVehicle.Infrastructure.Entity;

public sealed class DriverVehicleEntityConfiguration : IEntityTypeConfiguration<DriverVehicleEntity>
{
    public void Configure(EntityTypeBuilder<DriverVehicleEntity> builder)
    {
        builder.ToTable("drivers_vehicles");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.isActive)
            .HasColumnName("is_active")
            .HasColumnType("tinyint(1)")
            .IsRequired();

        builder.Property(x => x.assignedAt)
            .HasColumnName("assigned_at")
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(x => x.vehicleId)
            .HasColumnName("vehicle_id")
            .IsRequired();

        builder.Property(x => x.driverId)
            .HasColumnName("driver_id")
            .IsRequired();
    }
}