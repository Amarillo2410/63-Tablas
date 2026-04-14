using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.TripStatusHistory.Infrastructure.Entity;

public sealed class TripStatusHistoryEntityConfiguration : IEntityTypeConfiguration<TripStatusHistoryEntity>
{
    public void Configure(EntityTypeBuilder<TripStatusHistoryEntity> builder)
    {
        builder.ToTable("trip_status_history");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.statusName)
            .HasColumnName("status_name")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(x => x.locationCoords)
            .HasColumnName("location_coords")
            .HasColumnType("varchar(100)");

        builder.Property(x => x.createdAt)
            .HasColumnName("created_at")
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(x => x.tripId)
            .HasColumnName("trip_id")
            .IsRequired();
    }
}