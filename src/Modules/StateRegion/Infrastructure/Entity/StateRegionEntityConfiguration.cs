using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.StateRegion.Infrastructure.Entity;

public sealed class StateRegionEntityConfiguration : IEntityTypeConfiguration<StateRegionEntity>
{
    public void Configure(EntityTypeBuilder<StateRegionEntity> builder)
    {
        builder.ToTable("states_regions");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.name)
            .HasColumnName("name")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(x => x.countryId)
            .HasColumnName("country_id")
            .IsRequired();
    }
}