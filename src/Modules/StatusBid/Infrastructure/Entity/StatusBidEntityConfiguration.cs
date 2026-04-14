using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.StatusBid.Infrastructure.Entity;

public sealed class StatusBidEntityConfiguration : IEntityTypeConfiguration<StatusBidEntity>
{
    public void Configure(EntityTypeBuilder<StatusBidEntity> builder)
    {
        builder.ToTable("status_bids");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.name)
            .HasColumnName("name")
            .HasColumnType("varchar(100)")
            .IsRequired();
    }
}