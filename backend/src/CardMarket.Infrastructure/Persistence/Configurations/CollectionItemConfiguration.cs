using CardMarket.Core.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CardMarket.Infrastructure.Persistence.Configurations;

public class CollectionItemConfiguration : IEntityTypeConfiguration<CollectionItem>
{
    public void Configure(EntityTypeBuilder<CollectionItem> b)
    {
        b.Property(x => x.Condition).HasConversion<string>().HasMaxLength(20);
        b.Property(x => x.Notes).HasMaxLength(500);

        b.HasIndex(x => new { x.UserId, x.CardPrintingId, x.Condition }).IsUnique();

        b.HasOne(x => x.User)
            .WithMany()
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        b.HasOne(x => x.CardPrinting)
            .WithMany()
            .HasForeignKey(x => x.CardPrintingId)
            .OnDelete(DeleteBehavior.Restrict);

        b.ToTable(t => t.HasCheckConstraint("ck_collection_items_quantity_positive", "quantity >= 1"));
    }
}