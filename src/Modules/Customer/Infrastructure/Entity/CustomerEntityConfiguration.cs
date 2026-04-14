using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.Customer.Infrastructure.Entity;

public sealed class CustomerEntityConfiguration : IEntityTypeConfiguration<CustomerEntity>
{
    public void Configure(EntityTypeBuilder<CustomerEntity> builder)
    {
        builder.ToTable("customers");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.isFrequent)
            .HasColumnName("is_frequent")
            .HasColumnType("tinyint(1)")
            .IsRequired();

        builder.Property(x => x.companyName)
            .HasColumnName("company_name")
            .HasColumnType("varchar(150)");

        builder.Property(x => x.personId)
            .HasColumnName("person_id")
            .IsRequired();
    }
}