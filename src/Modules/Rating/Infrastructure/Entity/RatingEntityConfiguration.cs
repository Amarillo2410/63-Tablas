using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.Rating.Infrastructure.Entity;

public sealed class RatingEntityConfiguration : IEntityTypeConfiguration<RatingEntity>
{
    public void Configure(EntityTypeBuilder<RatingEntity> builder)
    {
        builder.ToTable("ratings");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.score)
            .HasColumnName("score")
            .IsRequired();

        builder.Property(x => x.comment)
            .HasColumnName("comment")
            .HasColumnType("varchar(500)");

        builder.Property(x => x.createdAt)
            .HasColumnName("created_at")
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(x => x.tripId)
            .HasColumnName("trip_id")
            .IsRequired();

        builder.Property(x => x.evaluatorId)
            .HasColumnName("evaluator_id")
            .IsRequired();

        builder.Property(x => x.evaluatedId)
            .HasColumnName("evaluated_id")
            .IsRequired();
    }
}