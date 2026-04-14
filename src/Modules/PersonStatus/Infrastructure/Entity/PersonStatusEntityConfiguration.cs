using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.PersonStatus.Infrastructure.Entity;

public sealed class PersonStatusEntityConfiguration : IEntityTypeConfiguration<PersonStatusEntity>
{
    public void Configure(EntityTypeBuilder<PersonStatusEntity> builder)
    {
        builder.ToTable("person_status");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.name)
            .HasColumnName("name")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(x => x.description)
            .HasColumnName("description")
            .HasColumnType("varchar(255)");
    }
}