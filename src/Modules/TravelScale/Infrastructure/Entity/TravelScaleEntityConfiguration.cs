using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.TravelScale.Infrastructure.Entity;

public sealed class TravelScaleEntityConfiguration : IEntityTypeConfiguration<TravelScaleEntity>
{
    public void Configure(EntityTypeBuilder<TravelScaleEntity> builder)
    {
        builder.ToTable("travel_scale");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.sequence)
            .HasColumnName("sequence")
            .IsRequired();

        builder.Property(x => x.arrivalEstimated)
            .HasColumnName("arrival_estimated")
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(x => x.departureActual)
            .HasColumnName("departure_actual")
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(x => x.tripId)
            .HasColumnName("trip_id")
            .IsRequired();
    }
}