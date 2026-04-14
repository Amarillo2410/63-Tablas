using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.Plan.Infrastructure.Entity;

public sealed class PlanEntityConfiguration : IEntityTypeConfiguration<PlanEntity>
{
    public void Configure(EntityTypeBuilder<PlanEntity> builder)
    {
        builder.ToTable("plans");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.name)
            .HasColumnName("name")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(x => x.price)
            .HasColumnName("price")
            .HasColumnType("decimal(10,2)")
            .IsRequired();

        builder.Property(x => x.durationDays)
            .HasColumnName("duration_days")
            .IsRequired();
    }
}