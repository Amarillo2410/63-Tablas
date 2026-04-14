using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.CompanyStatus.Infrastructure.Entity;

public sealed class CompanyStatusEntityConfiguration : IEntityTypeConfiguration<CompanyStatusEntity>
{
    public void Configure(EntityTypeBuilder<CompanyStatusEntity> builder)
    {
        builder.ToTable("companies_status");

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