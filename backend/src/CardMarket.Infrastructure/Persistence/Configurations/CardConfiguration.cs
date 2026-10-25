using CardMarket.Core.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CardMarket.Infrastructure.Persistence.Configurations;

public class CardConfiguration : IEntityTypeConfiguration<Card>
{
    public void Configure(EntityTypeBuilder<Card> b)
    {
        b.HasIndex(x => x.ExternalId).IsUnique();
        b.Property(x => x.Name).IsRequired().HasMaxLength(200);
        b.HasIndex(x => x.Name);
        b.Property(x => x.CardType).IsRequired().HasMaxLength(50);
        b.HasIndex(x => x.CardType);
        b.Property(x => x.Description).IsRequired();
        b.Property(x => x.Attribute).HasMaxLength(20);
        b.Property(x => x.Type).HasMaxLength(50);
        b.Property(x => x.Archetype).HasMaxLength(100);
        b.HasIndex(x => x.Archetype);
        b.Property(x => x.ImageUrl).HasMaxLength(500);
        b.Property(x => x.ImageSmallUrl).HasMaxLength(500);
    }
}