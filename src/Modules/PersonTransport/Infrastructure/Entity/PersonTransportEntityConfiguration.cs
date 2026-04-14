using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.PersonTransport.Infrastructure.Entity;

public sealed class PersonTransportEntityConfiguration : IEntityTypeConfiguration<PersonTransportEntity>
{
    public void Configure(EntityTypeBuilder<PersonTransportEntity> builder)
    {
        builder.ToTable("person_transport");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.roleInTrip)
            .HasColumnName("role_in_trip")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(x => x.tripId)
            .HasColumnName("trip_id")
            .IsRequired();

        builder.Property(x => x.personId)
            .HasColumnName("person_id")
            .IsRequired();
    }
}