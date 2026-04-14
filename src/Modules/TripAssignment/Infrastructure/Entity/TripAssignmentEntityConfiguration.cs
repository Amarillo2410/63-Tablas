using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.TripAssignment.Infrastructure.Entity;

public sealed class TripAssignmentEntityConfiguration : IEntityTypeConfiguration<TripAssignmentEntity>
{
    public void Configure(EntityTypeBuilder<TripAssignmentEntity> builder)
    {
        builder.ToTable("trip_assignments");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.assignedAt)
            .HasColumnName("assigned_at")
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(x => x.isConfirmed)
            .HasColumnName("is_confirmed")
            .HasColumnType("tinyint(1)")
            .IsRequired();

        builder.Property(x => x.tripId)
            .HasColumnName("trip_id")
            .IsRequired();

        builder.Property(x => x.driverId)
            .HasColumnName("driver_id")
            .IsRequired();
    }
}