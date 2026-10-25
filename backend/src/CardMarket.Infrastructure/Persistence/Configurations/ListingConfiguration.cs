using CardMarket.Core.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CardMarket.Infrastructure.Persistence.Configurations;

public class ListingConfiguration : IEntityTypeConfiguration<Listing>
{
    public void Configure(EntityTypeBuilder<Listing> b)
    {
        b.Property(x => x.UnitPrice).HasPrecision(12, 2);
        b.Property(x => x.Currency).IsRequired().HasMaxLength(3);
        b.Property(x => x.Description).HasMaxLength(500);
        b.Property(x => x.Status).HasConversion<string>().HasMaxLength(20);
        b.Property(x => x.Condition).HasConversion<string>().HasMaxLength(20);
        b.Property(x => x.Version).IsRowVersion();

        b.HasIndex(x => new { x.Status, x.CardPrintingId });
        b.HasIndex(x => new { x.SellerId, x.Status });

        b.HasOne(x => x.Seller)
            .WithMany()
            .HasForeignKey(x => x.SellerId)
            .OnDelete(DeleteBehavior.Restrict);

        b.HasOne(x => x.CardPrinting)
            .WithMany()
            .HasForeignKey(x => x.CardPrintingId)
            .OnDelete(DeleteBehavior.Restrict);

        b.ToTable(t =>
        {
            t.HasCheckConstraint("ck_listings_unit_price_positive", "unit_price > 0");
            t.HasCheckConstraint("ck_listings_quantity_non_negative", "quantity >= 0");
        });
    }
}