using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.PriceHistory.Infrastructure.Entity;

public sealed class PriceHistoryEntityConfiguration : IEntityTypeConfiguration<PriceHistoryEntity>
{
    public void Configure(EntityTypeBuilder<PriceHistoryEntity> builder)
    {
        builder.ToTable("price_history");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.oldPrice)
            .HasColumnName("old_price")
            .HasColumnType("decimal(10,2)")
            .IsRequired();

        builder.Property(x => x.newPrice)
            .HasColumnName("new_price")
            .HasColumnType("decimal(10,2)")
            .IsRequired();

        builder.Property(x => x.changeDate)
            .HasColumnName("change_date")
            .HasColumnType("datetime")
            .IsRequired();
    }
}