using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.Person.Infrastructure.Entity;

public sealed class PersonEntityConfiguration : IEntityTypeConfiguration<PersonEntity>
{
    public void Configure(EntityTypeBuilder<PersonEntity> builder)
    {
        builder.ToTable("persons");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.firstName)
            .HasColumnName("first_name")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(x => x.lastName)
            .HasColumnName("last_name")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(x => x.email)
            .HasColumnName("email")
            .HasColumnType("varchar(150)")
            .IsRequired();

        builder.Property(x => x.phone)
            .HasColumnName("phone")
            .HasColumnType("varchar(20)")
            .IsRequired();

        builder.Property(x => x.address)
            .HasColumnName("address")
            .HasColumnType("varchar(255)")
            .IsRequired();

        builder.Property(x => x.cityId)
            .HasColumnName("city_id")
            .IsRequired();

        builder.Property(x => x.statusId)
            .HasColumnName("status_id")
            .IsRequired();
    }
}