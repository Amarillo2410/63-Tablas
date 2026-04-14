using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.Entity1.Infrastructure.Entity;

public sealed class Entity1EntityConfiguration : IEntityTypeConfiguration<Entity1Entity>
{
    public void Configure(EntityTypeBuilder<Entity1Entity> builder)
    {
        builder.ToTable("entity1");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.name)
            .HasColumnName("name")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(x => x.data)
            .HasColumnName("data")
            .HasColumnType("varchar(500)");
    }
}