using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModeloTransporta.src.Modules.CreditWallet.Infrastructure.Entity;

public sealed class CreditWalletEntityConfiguration : IEntityTypeConfiguration<CreditWalletEntity>
{
    public void Configure(EntityTypeBuilder<CreditWalletEntity> builder)
    {
        builder.ToTable("credit_wallet");

        builder.HasKey(x => x.id);
        builder.Property(x => x.id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.balance)
            .HasColumnName("balance")
            .HasColumnType("decimal(10,2)")
            .IsRequired();

        builder.Property(x => x.lastUpdate)
            .HasColumnName("last_update")
            .HasColumnType("datetime")
            .IsRequired();

        builder.Property(x => x.personId)
            .HasColumnName("person_id");

        builder.Property(x => x.companyId)
            .HasColumnName("company_id");
    }
}