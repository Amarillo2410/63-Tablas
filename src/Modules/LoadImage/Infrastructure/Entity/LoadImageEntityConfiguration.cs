using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.LoadImage.Infrastructure.Entity;

public sealed class LoadImageEntityConfiguration : IEntityTypeConfiguration<LoadImageEntity>
{
    public void Configure(EntityTypeBuilder<LoadImageEntity> builder)
    {
        builder.ToTable("load_images");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.imageUrl)
            .HasColumnName("image_url")
            .HasColumnType("varchar(500)")
            .IsRequired();

        builder.Property(x => x.description)
            .HasColumnName("description")
            .HasColumnType("varchar(255)");

        builder.Property(x => x.createdAt)
            .HasColumnName("created_at")
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(x => x.loadId)
            .HasColumnName("load_id")
            .IsRequired();
    }
}