using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.Load.Infrastructure.Entity;

public sealed class LoadEntityConfiguration : IEntityTypeConfiguration<LoadEntity>
{
    public void Configure(EntityTypeBuilder<LoadEntity> builder)
    {
        builder.ToTable("loads");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.description)
            .HasColumnName("description")
            .HasColumnType("varchar(255)")
            .IsRequired();

        builder.Property(x => x.originAddress)
            .HasColumnName("origin_address")
            .HasColumnType("varchar(255)")
            .IsRequired();

        builder.Property(x => x.destinationAddress)
            .HasColumnName("destination_address")
            .HasColumnType("varchar(255)")
            .IsRequired();

        builder.Property(x => x.weight)
            .HasColumnName("weight")
            .HasColumnType("decimal(10,2)")
            .IsRequired();

        builder.Property(x => x.volume)
            .HasColumnName("volume")
            .HasColumnType("decimal(10,2)")
            .IsRequired();

        builder.Property(x => x.typeLoadId)
            .HasColumnName("type_load_id")
            .IsRequired();

        builder.Property(x => x.customerId)
            .HasColumnName("customer_id")
            .IsRequired();
    }
}