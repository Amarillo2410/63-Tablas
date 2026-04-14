using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.CompanyVehicle.Infrastructure.Entity;

public sealed class CompanyVehicleEntityConfiguration : IEntityTypeConfiguration<CompanyVehicleEntity>
{
    public void Configure(EntityTypeBuilder<CompanyVehicleEntity> builder)
    {
        builder.ToTable("company_vehicles");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.assignmentDate)
            .HasColumnName("assignment_date")
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(x => x.vehicleId)
            .HasColumnName("vehicle_id")
            .IsRequired();

        builder.Property(x => x.companyId)
            .HasColumnName("company_id")
            .IsRequired();
    }
}