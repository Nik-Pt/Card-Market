using CardMarket.Core.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CardMarket.Infrastructure.Persistence.Configurations;

public class CardPrintingConfiguration : IEntityTypeConfiguration<CardPrinting>
{
    public void Configure(EntityTypeBuilder<CardPrinting> b)
    {
        b.Property(x => x.SetCode).IsRequired().HasMaxLength(30);
        b.Property(x => x.SetName).IsRequired().HasMaxLength(150);
        b.Property(x => x.Rarity).IsRequired().HasMaxLength(50);

        b.HasIndex(x => new { x.CardId, x.SetCode, x.Rarity }).IsUnique();

        b.HasOne(x => x.Card)
            .WithMany(c => c.Printings)
            .HasForeignKey(x => x.CardId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}