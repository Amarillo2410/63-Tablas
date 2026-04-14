using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.DocumentVehicle.Infrastructure.Entity;

public sealed class DocumentVehicleEntityConfiguration : IEntityTypeConfiguration<DocumentVehicleEntity>
{
    public void Configure(EntityTypeBuilder<DocumentVehicleEntity> builder)
    {
        builder.ToTable("documents_vehicles");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.documentNumber)
            .HasColumnName("document_number")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(x => x.expirationDate)
            .HasColumnName("expiration_date")
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(x => x.fileUrl)
            .HasColumnName("file_url")
            .HasColumnType("varchar(500)")
            .IsRequired();

        builder.Property(x => x.vehicleId)
            .HasColumnName("vehicle_id")
            .IsRequired();

        builder.Property(x => x.typeDocumentId)
            .HasColumnName("type_document_id")
            .IsRequired();
    }
}