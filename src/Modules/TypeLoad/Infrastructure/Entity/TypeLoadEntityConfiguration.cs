using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.TypeLoad.Infrastructure.Entity;

public sealed class TypeLoadEntityConfiguration : IEntityTypeConfiguration<TypeLoadEntity>
{
    public void Configure(EntityTypeBuilder<TypeLoadEntity> builder)
    {
        builder.ToTable("type_load");

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
            .HasColumnType("varchar(255)")
            .IsRequired();
    }
}