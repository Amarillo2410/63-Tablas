using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.ReturnLoadSuggestion.Infrastructure.Entity;

public sealed class ReturnLoadSuggestionEntityConfiguration : IEntityTypeConfiguration<ReturnLoadSuggestionEntity>
{
    public void Configure(EntityTypeBuilder<ReturnLoadSuggestionEntity> builder)
    {
        builder.ToTable("return_load_suggestions");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.suggestedAt)
            .HasColumnName("suggested_at")
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(x => x.relevanceScore)
            .HasColumnName("relevance_score")
            .HasColumnType("decimal(5,2)")
            .IsRequired();

        builder.Property(x => x.currentTripId)
            .HasColumnName("current_trip_id")
            .IsRequired();

        builder.Property(x => x.suggestedLoadId)
            .HasColumnName("suggested_load_id")
            .IsRequired();
    }
}