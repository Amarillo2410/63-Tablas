using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.Payment.Infrastructure.Entity;

public sealed class PaymentEntityConfiguration : IEntityTypeConfiguration<PaymentEntity>
{
    public void Configure(EntityTypeBuilder<PaymentEntity> builder)
    {
        builder.ToTable("payments");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.amount)
            .HasColumnName("amount")
            .HasColumnType("decimal(10,2)")
            .IsRequired();

        builder.Property(x => x.transactionReference)
            .HasColumnName("transaction_reference")
            .HasColumnType("varchar(255)")
            .IsRequired();

        builder.Property(x => x.date)
            .HasColumnName("date")
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(x => x.providerId)
            .HasColumnName("provider_id")
            .IsRequired();

        builder.Property(x => x.statusId)
            .HasColumnName("status_id")
            .IsRequired();
    }
}