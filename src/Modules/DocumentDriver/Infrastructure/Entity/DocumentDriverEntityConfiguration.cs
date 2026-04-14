using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.DocumentDriver.Infrastructure.Entity;

public sealed class DocumentDriverEntityConfiguration : IEntityTypeConfiguration<DocumentDriverEntity>
{
    public void Configure(EntityTypeBuilder<DocumentDriverEntity> builder)
    {
        builder.ToTable("documents_drivers");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.documentNumber)
            .HasColumnName("document_number")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(x => x.expiryDate)
            .HasColumnName("expiry_date")
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(x => x.driverId)
            .HasColumnName("driver_id")
            .IsRequired();

        builder.Property(x => x.typeDocumentId)
            .HasColumnName("type_document_id")
            .IsRequired();

        builder.Property(x => x.statusId)
            .HasColumnName("status_id")
            .IsRequired();
    }
}