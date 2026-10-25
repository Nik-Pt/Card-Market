using CardMarket.Core.Enums;

namespace CardMarket.Core.Entities;

public class Listing
{
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public Guid SellerId { get; set; }
    public ApplicationUser Seller { get; set; } = null!;
    public Guid CardPrintingId { get; set; }
    public CardPrinting CardPrinting { get; set; } = null!;
    public CardCondition Condition { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public string Currency { get; set; } = "EUR";
    public string? Description { get; set; }
    public ListingStatus Status { get; set; } = ListingStatus.Active;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public uint Version { get; set; }

    public ICollection<Offer> Offers { get; set; } = new List<Offer>();
}