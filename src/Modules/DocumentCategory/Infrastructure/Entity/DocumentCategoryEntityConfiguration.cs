using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.DocumentCategory.Infrastructure.Entity;

public sealed class DocumentCategoryEntityConfiguration : IEntityTypeConfiguration<DocumentCategoryEntity>
{
    public void Configure(EntityTypeBuilder<DocumentCategoryEntity> builder)
    {
        builder.ToTable("document_category");

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