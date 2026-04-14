using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.Trip.Infrastructure.Entity;

public sealed class TripEntityConfiguration : IEntityTypeConfiguration<TripEntity>
{
    public void Configure(EntityTypeBuilder<TripEntity> builder)
    {
        builder.ToTable("trips");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.startDate)
            .HasColumnName("start_date")
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(x => x.endDate)
            .HasColumnName("end_date")
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(x => x.manifestNumber)
            .HasColumnName("manifest_number")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(x => x.totalPrice)
            .HasColumnName("total_price")
            .HasColumnType("decimal(10,2)")
            .IsRequired();

        builder.Property(x => x.loadId)
            .HasColumnName("load_id")
            .IsRequired();

        builder.Property(x => x.vehicleId)
            .HasColumnName("vehicle_id")
            .IsRequired();

        builder.Property(x => x.driverId)
            .HasColumnName("driver_id")
            .IsRequired();
    }
}