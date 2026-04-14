using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.Bid.Infrastructure.Entity;

public sealed class BidEntityConfiguration : IEntityTypeConfiguration<BidEntity>
{
    public void Configure(EntityTypeBuilder<BidEntity> builder)
    {
        builder.ToTable("bids");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.amount)
            .HasColumnName("amount")
            .HasColumnType("decimal(10,2)")
            .IsRequired();

        builder.Property(x => x.estimatedDelivery)
            .HasColumnName("estimated_delivery")
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(x => x.createdAt)
            .HasColumnName("created_at")
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(x => x.loadId)
            .HasColumnName("load_id")
            .IsRequired();

        builder.Property(x => x.driverId)
            .HasColumnName("driver_id")
            .IsRequired();

        builder.Property(x => x.statusBidId)
            .HasColumnName("status_bid_id")
            .IsRequired();
    }
}