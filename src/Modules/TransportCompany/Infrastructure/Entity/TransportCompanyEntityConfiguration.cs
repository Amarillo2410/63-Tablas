using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.TransportCompany.Infrastructure.Entity;

public sealed class TransportCompanyEntityConfiguration : IEntityTypeConfiguration<TransportCompanyEntity>
{
    public void Configure(EntityTypeBuilder<TransportCompanyEntity> builder)
    {
        builder.ToTable("transport_companies");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.name)
            .HasColumnName("name")
            .HasColumnType("varchar(150)")
            .IsRequired();

        builder.Property(x => x.taxId)
            .HasColumnName("tax_id")
            .HasColumnType("varchar(50)")
            .IsRequired();

        builder.Property(x => x.address)
            .HasColumnName("address")
            .HasColumnType("varchar(255)")
            .IsRequired();

        builder.Property(x => x.phone)
            .HasColumnName("phone")
            .HasColumnType("varchar(20)")
            .IsRequired();

        builder.Property(x => x.cityId)
            .HasColumnName("city_id")
            .IsRequired();
    }
}