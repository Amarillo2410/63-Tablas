using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.DocumentCustomer.Infrastructure.Entity;

public sealed class DocumentCustomerEntityConfiguration : IEntityTypeConfiguration<DocumentCustomerEntity>
{
    public void Configure(EntityTypeBuilder<DocumentCustomerEntity> builder)
    {
        builder.ToTable("documents_customers");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.documentNumber)
            .HasColumnName("document_number")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(x => x.customerId)
            .HasColumnName("customer_id")
            .IsRequired();

        builder.Property(x => x.typeDocumentId)
            .HasColumnName("type_document_id")
            .IsRequired();

        builder.Property(x => x.statusId)
            .HasColumnName("status_id")
            .IsRequired();
    }
}