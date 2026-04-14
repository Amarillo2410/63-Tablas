using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.TypeDocument.Infrastructure.Entity;

public sealed class TypeDocumentEntityConfiguration : IEntityTypeConfiguration<TypeDocumentEntity>
{
    public void Configure(EntityTypeBuilder<TypeDocumentEntity> builder)
    {
        builder.ToTable("type_documents");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.name)
            .HasColumnName("name")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(x => x.categoryId)
            .HasColumnName("category_id")
            .IsRequired();
    }
}