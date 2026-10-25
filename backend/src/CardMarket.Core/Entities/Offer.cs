using CardMarket.Core.Enums;

namespace CardMarket.Core.Entities;

public class Offer
{
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public Guid ListingId { get; set; }
    public Listing Listing { get; set; } = null!;
    public Guid BuyerId { get; set; }
    public ApplicationUser Buyer { get; set; } = null!;
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public string? Message { get; set; }
    public OfferStatus Status { get; set; } = OfferStatus.Pending;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? RespondedAt { get; set; }
}