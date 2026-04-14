using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.Subscription.Infrastructure.Entity;

public sealed class SubscriptionEntityConfiguration : IEntityTypeConfiguration<SubscriptionEntity>
{
    public void Configure(EntityTypeBuilder<SubscriptionEntity> builder)
    {
        builder.ToTable("subscriptions");

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

        builder.Property(x => x.planId)
            .HasColumnName("plan_id")
            .IsRequired();

        builder.Property(x => x.subscriberId)
            .HasColumnName("subscriber_id")
            .IsRequired();

        builder.Property(x => x.statusId)
            .HasColumnName("status_id")
            .IsRequired();
    }
}