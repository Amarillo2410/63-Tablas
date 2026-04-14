using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.CompanyDocument.Infrastructure.Entity;

public sealed class CompanyDocumentEntityConfiguration : IEntityTypeConfiguration<CompanyDocumentEntity>
{
    public void Configure(EntityTypeBuilder<CompanyDocumentEntity> builder)
    {
        builder.ToTable("company_documents");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.fileUrl)
            .HasColumnName("file_url")
            .HasColumnType("varchar(500)")
            .IsRequired();

        builder.Property(x => x.expiryDate)
            .HasColumnName("expiry_date")
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(x => x.companyId)
            .HasColumnName("company_id")
            .IsRequired();

        builder.Property(x => x.typeDocumentId)
            .HasColumnName("type_document_id")
            .IsRequired();
    }
}   