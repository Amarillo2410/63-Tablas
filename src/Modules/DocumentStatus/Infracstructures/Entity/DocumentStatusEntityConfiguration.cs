using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.DocumentStatus.Infrastructure.Entity;

public sealed class DocumentStatusEntityConfiguration : IEntityTypeConfiguration<DocumentStatusEntity>
{
    public void Configure(EntityTypeBuilder<DocumentStatusEntity> builder)
    {
        builder.ToTable("documents_status");

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