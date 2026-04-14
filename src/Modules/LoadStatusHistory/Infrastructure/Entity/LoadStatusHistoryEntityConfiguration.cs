using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.LoadStatusHistory.Infrastructure.Entity;

public sealed class LoadStatusHistoryEntityConfiguration : IEntityTypeConfiguration<LoadStatusHistoryEntity>
{
    public void Configure(EntityTypeBuilder<LoadStatusHistoryEntity> builder)
    {
        builder.ToTable("load_status_history");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.statusName)
            .HasColumnName("status_name")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(x => x.changedAt)
            .HasColumnName("changed_at")
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(x => x.notes)
            .HasColumnName("notes")
            .HasColumnType("varchar(500)");

        builder.Property(x => x.loadId)
            .HasColumnName("load_id")
            .IsRequired();

        builder.Property(x => x.changedById)
            .HasColumnName("changed_by_id")
            .IsRequired();
    }
}