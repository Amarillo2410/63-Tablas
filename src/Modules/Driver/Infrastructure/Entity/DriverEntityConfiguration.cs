using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.Driver.Infrastructure.Entity;

public sealed class DriverEntityConfiguration : IEntityTypeConfiguration<DriverEntity>
{
    public void Configure(EntityTypeBuilder<DriverEntity> builder)
    {
        builder.ToTable("drivers");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.licenseNumber)
            .HasColumnName("license_number")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(x => x.licenseCategory)
            .HasColumnName("license_category")
            .HasColumnType("varchar(50)")
            .IsRequired();

        builder.Property(x => x.experienceYears)
            .HasColumnName("experience_years")
            .IsRequired();

        builder.Property(x => x.personId)
            .HasColumnName("person_id")
            .IsRequired();
    }
}