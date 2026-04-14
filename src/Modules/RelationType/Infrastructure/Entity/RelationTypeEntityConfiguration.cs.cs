using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.RelationType.Infrastructure.Entity;

public sealed class RelationTypeEntityConfiguration : IEntityTypeConfiguration<RelationTypeEntity>
{
    public void Configure(EntityTypeBuilder<RelationTypeEntity> builder)
    {
        builder.ToTable("relation_type");

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