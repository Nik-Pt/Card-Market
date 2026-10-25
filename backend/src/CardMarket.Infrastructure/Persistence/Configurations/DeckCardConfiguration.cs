using CardMarket.Core.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CardMarket.Infrastructure.Persistence.Configurations;

public class DeckCardConfiguration : IEntityTypeConfiguration<DeckCard>
{
    public void Configure(EntityTypeBuilder<DeckCard> b)
    {
        b.HasKey(x => new { x.DeckId, x.CardId, x.Zone });

        b.Property(x => x.Zone).HasConversion<string>().HasMaxLength(10);

        b.HasOne(x => x.Deck)
            .WithMany(d => d.Cards)
            .HasForeignKey(x => x.DeckId)
            .OnDelete(DeleteBehavior.Cascade);

        b.HasOne(x => x.Card)
            .WithMany()
            .HasForeignKey(x => x.CardId)
            .OnDelete(DeleteBehavior.Restrict);

        b.ToTable(t => t.HasCheckConstraint("ck_deck_cards_quantity_range", "quantity >= 1 AND quantity <= 3"));
    }
}