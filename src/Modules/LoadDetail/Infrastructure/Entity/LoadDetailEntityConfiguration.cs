using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.LoadDetail.Infrastructure.Entity;

public sealed class LoadDetailEntityConfiguration : IEntityTypeConfiguration<LoadDetailEntity>
{
    public void Configure(EntityTypeBuilder<LoadDetailEntity> builder)
    {
        builder.ToTable("load_details");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.quantity)
            .HasColumnName("quantity")
            .IsRequired();

        builder.Property(x => x.unitMeasure)
            .HasColumnName("unit_measure")
            .HasColumnType("varchar(50)")
            .IsRequired();

        builder.Property(x => x.specialInstructions)
            .HasColumnName("special_instructions")
            .HasColumnType("varchar(500)");

        builder.Property(x => x.loadId)
            .HasColumnName("load_id")
            .IsRequired();
    }
}